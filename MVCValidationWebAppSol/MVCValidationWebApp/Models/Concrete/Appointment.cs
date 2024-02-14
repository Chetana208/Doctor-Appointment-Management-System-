using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCValidationWebApp.Models.Concrete
{
    public class Appointment
    {
        public string DoctorName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Appointment_Date { get; set; }
        public bool TermAccepted { get; set; }

    }
}