﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Lab3_ExamVersion.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(5)]
        public string PatientCode { get; set; }
        [Required]
        public string Gender { get; set; }
        public virtual List<Doctor> Doctors { get; set; }

        public Patient()
        {
            Doctors = new List<Doctor>();
        }
    }
}