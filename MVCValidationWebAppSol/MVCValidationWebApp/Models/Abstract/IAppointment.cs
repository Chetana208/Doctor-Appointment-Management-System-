
using MVCValidationWebApp.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCValidationWebApp.Models.Abstract
{
    public interface IAppointment
    {
        IEnumerable<Appointment> GetAll();
        void Save(Appointment appointment);

    }
}
