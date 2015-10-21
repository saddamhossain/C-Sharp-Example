using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBillCalculatorApp
{
    class Electric
    {
        public int ElectricityId { set; get; }
        public DateTime PreviousMonth { set; get; }
        public DateTime CurrentMonth { set; get; }
        public double PreviousUnits { set; get; }
        public double CurrentUnits { set; get; }
        public double TotalUnitConsumed { set; get; }
        public double TotalBillPayable { set; get; }

    }
}
