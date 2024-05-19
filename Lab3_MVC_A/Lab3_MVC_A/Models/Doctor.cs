﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_MVC_A.Models
{
    public class Doctor
    {
        public Doctor() { Patients = new List<Patient>(); }
        [Key]
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}