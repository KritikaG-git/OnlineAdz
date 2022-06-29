using System.ComponentModel.DataAnnotations;

namespace OnlineAdz.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage = "Please Specify your Role : Admin or User")]
        public string Role { get; set; }
        public string State { get; set; }
        public string City { get; set; }
       
        
    }
}
