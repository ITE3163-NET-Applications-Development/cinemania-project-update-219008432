using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class Message
    {
        [Key] public int Id { get; set; }
        [Required(ErrorMessage = "The name is required")]
        public string Names { get; set; }
        [Required(ErrorMessage = "Error occured, try again")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Can't find the subject")]
        public string subject { get; set; }

        [Required(ErrorMessage = "The message is required")]
        public string message { get; set; }
    }
}