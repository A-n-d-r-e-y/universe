using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe.Engine
{
    public interface ILogger
    {
        void WriteToLog(string message);
        void WriteNothing();
    }
}
