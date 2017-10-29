using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Universe.API.CustomValidationAttributes
{
    public class ValidValuesAttribute : ValidationAttribute
    {
        private string[] args;

        public ValidValuesAttribute(params string[] args)
        {
            this.args = args;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (args.Contains((string)value))
                return ValidationResult.Success;
            return new ValidationResult("Invalid value.");
        }
    }
}