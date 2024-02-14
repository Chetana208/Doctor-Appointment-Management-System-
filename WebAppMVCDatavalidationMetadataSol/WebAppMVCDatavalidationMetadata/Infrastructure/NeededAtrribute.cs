using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVCDatavalidationMetadata.Infrastructure
{
    public class NeededAttribute : ValidationAttribute, IClientValidatable
    {
        public NeededAttribute()
        {
            ErrorMessage = "Please Enter the name";
        }
        public override bool IsValid(object value)
        {
            return !string.IsNullOrEmpty((string)value);
        }
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            List<ModelClientValidationRule> rules = new List<ModelClientValidationRule>();
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ValidationType = "required";
            rule.ErrorMessage = ErrorMessage;
            rules.Add(rule);
            return rules;
        }
    }
}