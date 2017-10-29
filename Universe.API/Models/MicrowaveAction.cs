using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Universe.API.CustomValidationAttributes;

namespace Universe.API.Models
{

    public enum MicrowaveActions
    {
        OpenTheDoor,
        PressTheButton,
        CloseTheDoor
    }

    public class MicrowaveAction
    {
        //[ValidValues("OpenTheDoor", "PressTheButton", "CloseTheDoor")]
        [ValidEnumValues(typeof(MicrowaveActions))]
        public string ActionName { get; set; }
    }
}