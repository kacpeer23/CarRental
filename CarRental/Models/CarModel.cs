using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class CarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Marka")]
        [Required(ErrorMessage = "Marka jest wymagana")]
        [MinLength(2, ErrorMessage = "Marka musi posiadać co najmniej 2 znaki")]
/*        [Column(TypeName = "nvarchar(50)")]
*/        public string CarBrand { get; set; }
/*        [Column(TypeName = "nvarchar(50)")]
*/        [Display(Name = "Model")]
        [Required(ErrorMessage = "Model jest wymagane")]
        [MinLength(2, ErrorMessage = "Model musi posiadać co najmniej 2 znaki")]
        public string CarModelName { get; set; }
        /*[Column(TypeName = "nvarchar(50)")]*/
        [Required(ErrorMessage = "Rok produkcji jest wymagany")]
        [Display(Name = "Rok produkcji")]
        public int YearOfProduction { get; set; }
        /*[Column(TypeName = "nvarchar(50)")]*/
        [ValidateNever, Required]
        [Display(Name = "Paliwo")]
        public string Fuel { get; set; }
    }
}
