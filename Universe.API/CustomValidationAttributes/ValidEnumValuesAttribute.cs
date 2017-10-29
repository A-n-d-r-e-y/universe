using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Universe.API.CustomValidationAttributes
{
    public class ValidEnumValuesAttribute : ValidationAttribute
    {
        private Type enumType;

        public ValidEnumValuesAttribute(Type enumType)
        {
            if (!enumType.IsEnum) throw new ArgumentException("Type is not Enum.");

            this.enumType = enumType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (Enum.GetNames(enumType).Contains((string)value))
                return ValidationResult.Success;
            return new ValidationResult("Invalid value!");
        }
    }
}