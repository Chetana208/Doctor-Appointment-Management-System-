﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVCDatavalidationMetadata.Models.Concrete;

namespace WebAppMVCDatavalidationMetadata.Models.Abstract
{
    public interface IAppointment
    {
        IEnumerable<Appointment> GetAll();
        void Save(Appointment appointment);

    }
}
