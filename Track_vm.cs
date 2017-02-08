using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Controllers
{
    public class TrackBase
    {
        public int TrackId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Track name")]
        public string Name { get; set; }

        [Display(Name = "Album Identifier")]
        public int? AlbumId { get; set; }

        public int MediaTypeId { get; set; }

        [Display(Name = "Genre identifier")]
        public int? GenreId { get; set; }

        [StringLength(220)]
        [Display(Name = "Composer name(s)")]
        public string Composer { get; set; }

        [Display(Name = "Track length in milliseconds")]
        public int Milliseconds { get; set; }

        public int? Bytes { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Selling price")]
        public decimal UnitPrice { get; set; }
    }
}