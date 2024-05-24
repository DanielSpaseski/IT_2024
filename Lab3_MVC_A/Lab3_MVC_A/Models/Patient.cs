using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_MVC_A.Models
{
    public class Patient
    {
        public Patient() { Doctors = new List<Doctor>(); }
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameSurname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [MinLength(5, ErrorMessage ="Kodot mora da e tocno 5 karakteri")]
        [Display(Name ="Kod na pacientot")]
        public string Code { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}