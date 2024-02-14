using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMVCDatavalidationMetadata.Models.Abstract;

namespace WebAppMVCDatavalidationMetadata.Models.Concrete
{
    public class FakeRepo : IAppointment
    {
        static List<Appointment> _appointments = new List<Appointment>();
            
        public IEnumerable<Appointment> GetAll()
        {
            return _appointments;
        }

        public void Save(Appointment appointment)
        {
            _appointments.Add(appointment);
        }
    }
}