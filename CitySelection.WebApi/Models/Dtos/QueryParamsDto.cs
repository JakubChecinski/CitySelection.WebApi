using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Dtos
{
    /*
        Importance codes:
            Irrelevant = 0
            NiceToHave = 1
            Important = 2
            Mandatory = 3
        Preference codes:
            N/A = 0
            Low = 1
            Medium = 2
            High = 3

        Other codes will result in throwing an exception.

        If the importance code is set to irrelevant, the preference code will be ignored.
        For the sake of clarity, it is recommended to use N/A (zero).
    */
    public class QueryParamsDto
    {
        public int GdpPerCapitaImportance { get; set; }
        public int GdpPerCapitaPreference { get; set; }
        public int InequalityIndexImportance { get; set; }
        public int InequalityIndexPreference { get; set; }
        public int RainyDaysImportance { get; set; }
        public int RainyDaysPreference { get; set; }
        public int MonthlySunshineHoursImportance { get; set; }
        public int MonthlySunshineHoursPreference { get; set; }
        public int Temperature24hAvgHighImportance { get; set; }
        public int Temperature24hAvgHighPreference { get; set; }
        public int Temperature24hAvgLowImportance { get; set; }
        public int Temperature24hAvgLowPreference { get; set; }
        public int AnnualPM2_5ConcentrationImportance { get; set; }
        public int AnnualPM2_5ConcentrationPreference { get; set; }
        public int CostOfLivingIndexImportance { get; set; }
        public int CostOfLivingIndexPreference { get; set; }
    }

}
