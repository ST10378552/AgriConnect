using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string FarmerEmail { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}