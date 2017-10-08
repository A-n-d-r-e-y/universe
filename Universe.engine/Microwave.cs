using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe.Engine
{
    public class Microwave : IStateReporter, IMicrowave
    {
        private readonly ILogger logger;

        public bool IsDoorOpen { get; set; }
        public bool IsLampOn { get; set; }
        public bool IsEngineWorking { get; set; }

        public Microwave() { }

        public Microwave(ILogger logger)
        {
            this.logger = logger;
        }

        public void OpenTheDoor()
        {
            if (!IsDoorOpen)
            {
                if (IsEngineWorking) IsEngineWorking = false;
                IsDoorOpen = true;
                IsLampOn = true;

                if (logger != null) logger.WriteToLog("Opening the door");
            }
            else if (logger != null) logger.WriteNothing();
        }
        public void CloseTheDoor()
        {
            if (IsDoorOpen)
            {
                IsDoorOpen = false;
                IsLampOn = false;

                if (logger != null) logger.WriteToLog("Closing the door");
            }
            else if (logger != null) logger.WriteNothing();
        }

        public void PressTheButton()
        {
            if (!IsDoorOpen && !IsEngineWorking)
            {
                IsEngineWorking = true;
                if (logger != null) logger.WriteToLog("The engine is working now");
            }
            else if (logger != null) logger.WriteNothing();
        }

        public void ReportTheState()
        {
            var sb = new StringBuilder();
            if (IsDoorOpen) sb.AppendLine("The door is open");
            else sb.AppendLine("The door is closed");

            if (IsLampOn) sb.AppendLine("The lamp is on");
            else sb.AppendLine("The lamp is off");

            if (IsEngineWorking) sb.AppendLine("The engine is working");
            else sb.AppendLine("The engine is not working");

            logger.WriteToLog(sb.ToString());
        }
    }
}
