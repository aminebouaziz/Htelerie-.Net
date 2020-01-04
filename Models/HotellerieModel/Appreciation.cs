using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotellerie_Amine_.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Display(Name = "Nom Personne")]
        public String NomPers { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public String Commentaire { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Range(1, 5, ErrorMessage = "range 1 a 5 ")]
        public int Note { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}