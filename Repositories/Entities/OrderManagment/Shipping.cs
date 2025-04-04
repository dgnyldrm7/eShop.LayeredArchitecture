namespace App.Core.Entities.OrderManagment
{
    public class Shipping 
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = default!;
        public string TrackingNumber { get; set; } = default!;

        //Navigation Properties
        public int OrderId { get; set; }
        public Order Order { get; set; } = new();
    }
}