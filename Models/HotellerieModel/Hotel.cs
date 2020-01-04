using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotellerie_Amine_.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(15,MinimumLength = 3 ,ErrorMessage ="min 3 max 15")]
        public String Nom { get; set; }
        [Range(1,5,ErrorMessage ="range 1 a 5 ")]
        public  int Etoiles { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public String Ville { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Url(ErrorMessage ="ce n'est pas un url valide")]
        [Display(Name ="Site Web ")]
        public String SiteWeb { get; set; }
        public String Pays { get; set; }
        public String lieu { get; set; }
        public virtual ICollection<Appreciation> Appreciations { get; set; }
    }
}