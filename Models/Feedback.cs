using System.ComponentModel.DataAnnotations;

namespace DNET_Practical_7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a course")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter your comments")]
        [StringLength(200, ErrorMessage = "Comments cannot exceed 200 characters")]
        public string Comments { get; set; }
    }
}