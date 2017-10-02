using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universe.Engine;

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





 
}
