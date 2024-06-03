using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Lab3_ExamVersion.Models
{
    public class DoctorPatient
    {
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public List<Patient> patients { get; set; }
        public DoctorPatient() { patients = new List<Patient>(); }
    }
}