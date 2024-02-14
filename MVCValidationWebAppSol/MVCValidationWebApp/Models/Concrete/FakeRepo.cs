using MVCValidationWebApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCValidationWebApp.Models.Concrete
{
    public class FakeRepo : IAppointment
    {
        static List<Appointment> _appoimtment = new List<Appointment>();
        public IEnumerable<Appointment> GetAll()
        {
            return _appoimtment;
        }

        public void Save(Appointment appointment)
        {
            _appoimtment.Add(appointment);
            
        }
    }
}