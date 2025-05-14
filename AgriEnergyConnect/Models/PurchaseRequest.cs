using System.ComponentModel.DataAnnotations;
namespace AgriEnergyConnect.Models
{
    public class PurchaseRequest
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; } 
        public Product Product { get; set; }

        [Required]
        public string RequestingFarmerEmail { get; set; }

        public DateTime RequestedOn { get; set; } = DateTime.Now;

        public bool IsApproved { get; set; } = false;
    }
}