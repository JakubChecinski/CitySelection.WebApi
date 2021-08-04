using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models
{
    public class CityAsCodes
    {
        public int CityId { get; set; }
        public int GdpPerCapita { get; set; }
        public int InequalityIndex { get; set; }
        public int RainyDays { get; set; }
        public int MonthlySunshineHours { get; set; }
        public int Temperature24hAvgHigh { get; set; }
        public int Temperature24hAvgLow { get; set; }
        public int AnnualPM2_5Concentration { get; set; }
        public int CostOfLivingIndex { get; set; }
    }
}
