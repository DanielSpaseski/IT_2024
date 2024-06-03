using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Lab3_ExamVersion.Models
{
    public class HospitalDoctor
    {
        public int hospitalId { get; set; }
        public int doctorId { get; set; }
        public List<Doctor> doctors { get; set; }  
        public HospitalDoctor() { doctors = new List<Doctor>(); }
    }
}