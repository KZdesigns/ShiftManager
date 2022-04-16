using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.UI
{
    class ProductionWorker : Employee
    {
        public int shiftNumber { get; set; }
        public double hourlyRate { get; set; }
    }
}
