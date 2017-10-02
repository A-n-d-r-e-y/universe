using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe.Engine
{
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
