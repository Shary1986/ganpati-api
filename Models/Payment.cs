namespace GanpatiPaymentsAPI.Models
{
    public class Payment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Tower { get; set; }
        public string Flat { get; set; }
        public decimal Amount { get; set; }
        public string OwnerTenant { get; set; }
        public string Status { get; set; }
        public string PaidThrough { get; set; }
        public string UpiId { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public DateTime SavedAt { get; set; }
    }
}
