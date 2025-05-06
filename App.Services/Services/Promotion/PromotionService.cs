using App.Core.Entities.PromotionManagment;
using App.Core.Entities.UserManagment;
using App.Core.Interfaces.UnitOfWork;
using App.Core.Result;
using App.Persistance.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Services.Services.Promotion
{
    public class PromotionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _context;
        public PromotionService(IUnitOfWork unitOfWork, AppDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }


        /// <summary>
        /// Kupon oluşturma işlemi
        /// </summary>
        /// <param name="coupon"></param>
        /// <returns></returns>
        public async Task<(string, Coupon?)> CreateCouponAsync(Coupon coupon)
        {
            if (coupon.StartDate >= coupon.EndDate)
            {
                return ("Başlangıç tarihi, bitiş tarihinden sonra olamaz.", null);
            }

            coupon.IsActive = true;

            await _context.coupons.AddAsync(coupon);

            await _unitOfWork.SaveChangesAsync(CancellationToken.None);

            return ("Kupon başarıyla oluşturuldu.", coupon);
        }

        /// <summary>
        /// Kupon geçerlimi kontrol eder.
        /// </summary>
        /// <param name="coupon"></param>
        /// <returns></returns>
        public bool IsCouponValid(Coupon coupon)
        {
            return coupon.IsActive &&
                   coupon.StartDate <= DateTime.UtcNow &&
                   coupon.EndDate >= DateTime.UtcNow &&
                   coupon.UsedCount < coupon.UsageLimit;
        }

        /// <summary>
        /// Userların couponlarını getir.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<UserCoupon>> GetUserCouponsAsync(string userId)
        {
            return await _context.userCoupons
                .Where(uc => uc.UserId == userId)
                .Include(uc => uc.Coupon)
                .ToListAsync();
        }

        /// <summary>
        /// Geçerli kupona sahip user couponları getir.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<UserCoupon>> GetValidUserCouponsAsync(string userId)
        {
            var currentDate = DateTime.UtcNow;

            return await _context.userCoupons
                .Where(uc => uc.UserId == userId &&
                             !uc.IsUsed &&
                             uc.ExpirationDate > currentDate &&
                             uc.Coupon!.IsActive &&
                             uc.Coupon.EndDate > currentDate)
                .Include(uc => uc.Coupon)
                .ToListAsync();
        }

        /// <summary>
        /// Kupon kullanma işlemidir!
        /// </summary>
        /// <param name="userCouponId"></param>
        /// <returns></returns>
        public async Task<ServiceResult> UseCouponAsync(string userCouponId)
        {
            var userCoupon = await _context.userCoupons
                .Include(uc => uc.Coupon)
                .FirstOrDefaultAsync(uc => uc.Id.ToString() == userCouponId);

            if (userCoupon == null)
            {
                return ServiceResult.FailResult("Kupon bulunamadı.");
            }

            if (userCoupon.IsUsed)
            {
                return ServiceResult.FailResult("Kupon zaten kullanılmış.");
            }

            if (!IsCouponValid(userCoupon.Coupon!))
            {
                return ServiceResult.FailResult("Kupon geçerli değil.");
            }

            userCoupon.IsUsed = true;
            userCoupon.UsedDate = DateTime.UtcNow;
            userCoupon.Coupon!.UsedCount += 1;

            await _unitOfWork.SaveChangesAsync(CancellationToken.None);

            return ServiceResult.SuccessResult("Kupon başarıyla kullanıldı.");
        }

        /// <summary>
        /// Kuponu iptal etme işlemidir!
        /// </summary>
        /// <param name="userCouponId"></param>
        /// <returns></returns>
        public async Task<ServiceResult> CancelCouponAsync(string userCouponId)
        {
            var userCoupon = await _context.userCoupons
                .Include(uc => uc.Coupon)
                .FirstOrDefaultAsync(uc => uc.Id.ToString() == userCouponId);

            if (userCoupon == null)
            {
                return ServiceResult.FailResult("Kupon bulunamadı.");
            }

            if (!userCoupon.IsUsed)
            {
                return ServiceResult.FailResult("Kupon daha önce kullanılmamış.");
            }

            userCoupon.IsUsed = false;
            userCoupon.UsedDate = null;
            userCoupon.Coupon!.UsedCount = Math.Max(0, userCoupon.Coupon.UsedCount - 1);

            await _unitOfWork.SaveChangesAsync(CancellationToken.None);

            return ServiceResult.SuccessResult("Kupon iptal edildi.");
        }

        /// <summary>
        /// Kullanıcı kuponunun sistemde olup olmadığını kontrol etme
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="couponId"></param>
        /// <returns></returns>
        public ServiceResult HasUserCoupon(string userId, int couponId)
        {
            var inHas = _context.userCoupons.AnyAsync(uc => uc.UserId == userId && uc.CouponId == couponId);

            if (inHas.Result)
            {
                return ServiceResult.SuccessResult("Kupon mevcut.");
            }

            return ServiceResult.FailResult("Kupon mevcut değil.");
        }

        /// <summary>
        /// Kupon pasifleştirme işlemidir.
        /// </summary>
        /// <param name="couponId"></param>
        /// <returns></returns>
        public async Task<ServiceResult> DeactivateCouponAsync(int couponId)
        {
            var coupon = await _context.coupons.FindAsync(couponId);

            if (coupon == null)
            {
                return ServiceResult.FailResult("Kupon bulunamadı");
            }

            coupon.IsActive = false;

            await _unitOfWork.SaveChangesAsync(CancellationToken.None);

            return ServiceResult.SuccessResult("Kupon devre dışı bırakıldı");
        }


        /// <summary>
        /// Kullanıcıya yeni coupon tanımlama!
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="couponId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<ServiceResult> AssignCouponToUserAsync(string userId, int couponId)
        {
            var coupon = await _context.coupons.FirstOrDefaultAsync(c => c.Id == couponId);

            if (coupon == null || !IsCouponValid(coupon))
            {
                return ServiceResult.FailResult("Kupon geçerli değil");
            }

            var userCoupon = new UserCoupon
            {
                UserId = userId,
                CouponId = couponId,
                AssignedDate = DateTime.UtcNow,
                ExpirationDate = coupon.EndDate,
                IsUsed = false
            };

            await _context.userCoupons.AddAsync(userCoupon);

            await _unitOfWork.SaveChangesAsync(CancellationToken.None);

            return ServiceResult.SuccessResult("Müşteriye başarıyla kupon ataması gerçekleştirildi.");
        }

    }
}
