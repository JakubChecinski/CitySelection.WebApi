using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models
{
    public class QueryParams
    {
        public int[] GdpPerCapita { get; set; }
        public int[] InequalityIndex { get; set; }
        public int[] RainyDays { get; set; }
        public int[] MonthlySunshineHours { get; set; }
        public int[] Temperature24hAvgHigh { get; set; }
        public int[] Temperature24hAvgLow { get; set; }
        public int[] AnnualPM2_5Concentration { get; set; }
        public int[] CostOfLivingIndex { get; set; }

        public QueryParams()
        {
            // convention: importance, preference
            GdpPerCapita = new int[2];
            InequalityIndex = new int[2];
            RainyDays = new int[2];
            MonthlySunshineHours = new int[2];
            Temperature24hAvgHigh = new int[2];
            Temperature24hAvgLow = new int[2];
            AnnualPM2_5Concentration = new int[2];
            CostOfLivingIndex = new int[2];
        }

    }
}
