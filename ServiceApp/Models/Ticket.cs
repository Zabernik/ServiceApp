using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceApp.Models
{
    public enum Priority
    {
        [Display(Name ="Wysoki")]
        high,
        [Display(Name ="Średni")]
        medium,
        [Display(Name ="Niski")]
        low
    }

    public class Ticket
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name ="Tytuł Zgłoszenia")]
        [Required(ErrorMessage ="Nie podano tematu zgłoszenia")]
        public string Title { get; set; }
        [Display(Name ="Opis")]
        [Required(ErrorMessage ="Nie opisałeś problemu z działaniem maszyny")]
        [StringLength(maximumLength: 2000, MinimumLength = 10, ErrorMessage = "Opis musi zawierać między 10 a 2000 znaków")]
        public string Description { get; set; }
        [Display(Name ="Zgłaszający")]
        public string Author { get; set; }
        [Display(Name ="Identyfikator Maszyny")]
        public int? MachineId { get; set; }
        [HiddenInput]
        [Display(Name ="Utworzony")]
        public DateTime CreatedAt { get; set; }
        [HiddenInput]
        [Display(Name ="Zaktualizowany")]
        public DateTime? LastUpdatedAt { get; set; }
        [Display(Name ="Priorytet")]
        public Priority? Priority { get; set; }
    }
}
