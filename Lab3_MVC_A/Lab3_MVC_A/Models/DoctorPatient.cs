﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_MVC_A.Models
{
    public class DoctorPatient
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public List<Patient> Patients { get; set; }
    }
}