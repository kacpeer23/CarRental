using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class RegisterModel
    {
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Display(Name = "Hasło")]
        public string Password { get; set; }
    }
}
