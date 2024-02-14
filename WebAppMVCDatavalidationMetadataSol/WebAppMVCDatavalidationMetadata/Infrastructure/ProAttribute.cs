using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppMVCDatavalidationMetadata.Models.Concrete;

namespace WebAppMVCDatavalidationMetadata.Infrastructure
{
    public class ProAttribute:ValidationAttribute
    {
        public ProAttribute() {
            ErrorMessage = "C appointment on monday is prohibited";
        }
        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrEmpty(app.DoctorName) || app.Appointment_Date == null)
            {
                return true;
            }
            return !(app.DoctorName == "C" && app.Appointment_Date.DayOfWeek == DayOfWeek.Monday);
        }
    }
}