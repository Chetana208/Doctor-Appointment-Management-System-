﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMVCDatavalidationMetadata.Infrastructure
{
    public class DateInFutureAttribute : RequiredAttribute
    {
        public DateInFutureAttribute() {
            ErrorMessage = "Please Enter Future Date";
        }
        public override bool IsValid(object value)
        {
            return base.IsValid(value) &&
                value is DateTime &&
                ((DateTime)value) > DateTime.Now;
        }
    }
}