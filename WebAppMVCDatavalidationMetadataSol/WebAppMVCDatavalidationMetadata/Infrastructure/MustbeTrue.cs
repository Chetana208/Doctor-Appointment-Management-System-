using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVCDatavalidationMetadata.Infrastructure
{
    public class MustbeTrue : ValidationAttribute
    {
        public MustbeTrue() {
            ErrorMessage = "Accept Terms";
        }
        public override bool IsValid(object value)
        {
            return value is bool &&((bool)value)==true;
        }
    }
    public class MustbeTrueClient:ValidationAttribute,IClientValidatable
    {
        public MustbeTrueClient()
        {
            ErrorMessage = "Please Accept the Terms";
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            List<ModelClientValidationRule> rules = new List<ModelClientValidationRule> ();
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ValidationType = "checkboxtrue";
            rule.ErrorMessage = ErrorMessage;
            rules.Add(rule);
            return rules;

        }
        public override bool IsValid(object value)
        {
            return value is bool && ((bool) value) == true;
        }


    }
}