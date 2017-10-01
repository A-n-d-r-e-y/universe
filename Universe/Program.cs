using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe
{
    class Program
    {
        static void Main(string[] args)
        {
            var lg = new ConsoleLogger();
            var mw = new Microwave(lg);
            var sb = new StringBuilder();

            while(true)
            {
                if (mw is IStateReporter) mw.ReportTheState();

                sb.AppendLine("Possible actions: ");
                sb.AppendLine("1. Open the door");
                sb.AppendLine("2. Close the door");
                sb.AppendLine("3. Press the button");
                sb.AppendLine("Choose one and press the key!");
                sb.AppendLine();

                lg.WriteToLog(sb.ToString());
                sb.Clear();

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        mw.OpenTheDoor();
                        break;
                    case '2':
                        mw.CloseTheDoor();
                        break;
                    case '3':
                        mw.PressTheButton();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public class Microwave : IStateReporter
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
            if(!IsDoorOpen && !IsEngineWorking)
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

    public interface IStateReporter
    {
        void ReportTheState();
    }

    public interface ILogger
    {
        void WriteToLog(string message);
        void WriteNothing();
    }

    public class ConsoleLogger : ILogger
    {
        public void WriteToLog(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }

        public void WriteNothing()
        {
            Console.WriteLine();
            Console.WriteLine("Nothing happenned...");
        }
    }
}
