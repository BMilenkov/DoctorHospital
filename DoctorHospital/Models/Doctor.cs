using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorHospital.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public Hospital hospital { get; set; }
        public virtual List<Patient> patients { get; set; }

        public Doctor() { patients = new List<Patient>(); }
    }
}