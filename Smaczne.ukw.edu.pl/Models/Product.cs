using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smaczne.ukw.edu.pl.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę produktu.")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać opis.")]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "prosze podać cene.")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Proszę podać kategorię.")]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
    }
}
