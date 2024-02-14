using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMVCSelfValidation.Models.Abstract;

namespace WebAppMVCSelfValidation.Models.Concrete
{
    public class FakeRepo : IAppointment
    {
        static List<Appointment>_appointment=new List<Appointment>();
        public IEnumerable<Appointment> GetAll()
        {
            return _appointment;
        }

        public void Save(Appointment appointment)
        {
            _appointment.Add(appointment);
        }
    }
}