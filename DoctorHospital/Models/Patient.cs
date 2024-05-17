using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorHospital.Models
{
    public class Patient
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Името е задолжително!")]
        public string name { get; set; }
        [Required]
        [RegularExpression(@"^\d{5}$",ErrorMessage ="Невалиден код!")]
        [Display(Name="Код на пациентот")]
        public int code { get; set; }
        public string gender { get; set; }
        public virtual List<Doctor> doctors { get; set; }

        public Patient() { doctors = new List<Doctor>(); }
    }
}