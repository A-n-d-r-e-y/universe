using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Universe.API.CustomValidationAttributes;

namespace Universe.API.Models
{
    public class MicrowaveAction
    {
        [ValidValues("OpenTheDoor", "PressTheButton", "CloseTheDoor")]
        public string ActionName { get; set; }
    }
}