using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GanpatiPaymentsAPI.Models
{
    public class Payment
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tower")]
        public string Tower { get; set; }

        [JsonPropertyName("flat")]
        public string Flat { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("ownerTenant")]
        public string OwnerTenant { get; set; }

        [JsonPropertyName("paidThrough")]
        public string PaidThrough { get; set; }

        [JsonPropertyName("upiId")]
        public string UpiId { get; set; }

        [JsonPropertyName("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonPropertyName("emailId")]
        public string EmailId { get; set; }

        [JsonPropertyName("savedAt")]
        public DateTime SavedAt { get; set; }
    }
}
