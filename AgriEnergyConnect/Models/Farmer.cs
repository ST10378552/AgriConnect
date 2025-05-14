using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class Farmer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [Display(Name = "Full Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Farm Size (hectares)")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Farm size must be greater than zero.")]
        public double FarmSize { get; set; }

        [Display(Name = "Years of Experience")]
        [Range(0, 100, ErrorMessage = "Experience must be between 0 and 100 years.")]
        public int YearsOfExperience { get; set; }
    }
}