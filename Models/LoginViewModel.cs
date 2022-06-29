using System.ComponentModel.DataAnnotations;

namespace OnlineAdz.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        [DataType(DataType.Password)]
        
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
