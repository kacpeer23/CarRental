using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class AccidentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Samochód jest wymagany")]
        [Display(Name = "Samochód")]
        [MinLength(2, ErrorMessage = "Samochód musi posiadać co najmniej 2 znaki")]
        public string Car { get; set; }
        [Display(Name = "Klient")]
        [Required(ErrorMessage = "Klient jest wymagany")]
        [MinLength(2, ErrorMessage = "Klient musi posiadać co najmniej 2 znaki")]
        public string Client { get; set; }
        [Display(Name = "Opis zgłoszenia")]
        public string Description { get; set; }
        [Display(Name = "Data zgłoszenia")]
        [Required(ErrorMessage = "Data zgłoszenia jest wymagana")]
        public DateTime DateOfAccident { get; set; }
    }
}
