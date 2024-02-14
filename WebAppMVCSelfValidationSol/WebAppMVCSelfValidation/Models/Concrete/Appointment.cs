using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMVCSelfValidation.Models.Concrete
{
    public class Appointment :IValidatableObject
    {
        public string DoctorName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Appointment_Date { get; set; }
        public bool TermAccepted { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();
           
            if (string.IsNullOrEmpty(DoctorName))
            {
                result.Add(new ValidationResult("Please Enter the Name", new[] { "DoctorName" }));
            }
            if (Appointment_Date < DateTime.Now)
            {
                result.Add(new ValidationResult("Please Enter Future Date", new[] { "Appointment_Date" }));
            }
            if (!TermAccepted)
            {
                result.Add(new ValidationResult("Please Acceptd the terms", new[] { "TermAccepted" }));
            }
            if (result.Count==0 &&
               DoctorName=="C" &&
               Appointment_Date.DayOfWeek==DayOfWeek.Monday)
            {
                result.Add(new ValidationResult("C not available on Monday"));
            }
            return result;
        }
    }
}