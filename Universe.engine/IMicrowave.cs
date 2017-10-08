using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe.Engine
{
    public interface IMicrowave
    {
        bool IsDoorOpen { get; set; }
        bool IsLampOn { get; set; }
        bool IsEngineWorking { get; set; }
    }
}
