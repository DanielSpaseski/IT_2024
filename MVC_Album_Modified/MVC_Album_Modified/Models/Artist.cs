using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Album_Modified.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [Display(Name = "Artist Name")]
        [Required]
        public string Name { get; set; }
    }
}