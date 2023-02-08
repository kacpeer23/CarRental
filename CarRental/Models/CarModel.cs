using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Marka jest wymagana")]
        [MinLength(2, ErrorMessage = "Marka musi posiadać co najmniej 2 znaki")]
        public string CarBrand { get; set; }

        [Required(ErrorMessage = "Model jest wymagane")]
        [MinLength(2, ErrorMessage = "Model musi posiadać co najmniej 2 znaki")]
        public string CarModelName { get; set; }

        [Required(ErrorMessage = "Rok produkcji jest wymagany")]
        [MinLength(4, ErrorMessage = "Rok produkcji musi posiadać co najmniej 4 znaki")]
        public int YearOfProduction { get; set; }

        [ValidateNever, Required]
        public string Fuel { get; set; }
    }
}
