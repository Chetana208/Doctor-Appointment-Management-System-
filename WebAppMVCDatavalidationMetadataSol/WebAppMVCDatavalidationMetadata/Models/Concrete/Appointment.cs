using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Web;
using WebAppMVCDatavalidationMetadata.Infrastructure;

namespace WebAppMVCDatavalidationMetadata.Models.Concrete
{
    [ProAttribute]
    public class Appointment
    {
        [Required(ErrorMessage ="Please Enter the name")]
        public string DoctorName { get; set; }
        [DataType(DataType.Date)]
        [DateInFuture]
        public DateTime Appointment_Date { get; set; }
        [MustbeTrue]
        public bool TermAccepted { get; set; }
    }
}