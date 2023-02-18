using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class EmployeeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Stanowisko pracy jest wymagane")]
        [Display(Name = "Stanowisko pracy")]
        public string JobPosition { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [MinLength(2, ErrorMessage = "Nazwisko musi posiadać co najmniej 2 znaki")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MinLength(2, ErrorMessage = "Nazwisko musi posiadać co najmniej 2 znaki")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "E-mail jest wymagany")]
        [EmailAddress(ErrorMessage = "Wpisany tekst nie jest adresem e-mail")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [ValidateNever, Required]
        [Phone(ErrorMessage = "To nie jest numer telefonu")]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }
    }
}
