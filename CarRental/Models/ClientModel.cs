using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace CarRental.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
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
        [Required(ErrorMessage = "Wypożyczany samochód jest wymagany")]
        [MinLength(2, ErrorMessage = "Wypożyczany samochód musi posiadać co najmniej 2 znaki")]
        [Display(Name = "Wypożyczany samochód")]
        public string RentalCar { get; set; }
        [ValidateNever, Required]
        [Phone(ErrorMessage = "To nie jest numer telefonu")]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }
        [ValidateNever, Required]
        [Display(Name = "Data rozpoczęcia wypożyczenia")]
        public DateTime RentalDate { get; set; }
        [ValidateNever, Required]
        [Display(Name = "Data zakończenia wypożyczenia")]
        public DateTime EndDate { get; set; }   
        
    }
}
