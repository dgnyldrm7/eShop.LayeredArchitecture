namespace App.Core.Entities.OrderManagment
{
    public class Shipping 
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = default!;
        public string TrackingNumber { get; set; } = default!;
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string Address { get; set; } = default!;
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string ZipCode { get; set; } = default!;
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}