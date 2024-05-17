using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorHospital.Models
{
    public class PatientDoctor
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public List<Patient> patients { get; set; }
        public PatientDoctor() { patients = new List<Patient>(); }
    }
}