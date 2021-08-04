using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Services
{
    public static class DataHelper
    {
        // class containing numeric extremes for all city parameters
        // perhaps to do: write a method that will update these automatically based on db content
        // (note - it doesn't make sense to load these values during every query,
        // but it would be nice to have a way to update once database itself is updated)

        // convention: tab[0] is minimum, tab[1] is maximum
        public static int[] GdpPerCapitas { get; set; } = new int[2] { 32950, 99239 };
        public static double[] InequalityIndices { get; set; } = new double[2] { 26.8, 34.8 };
        public static int[] RainyDays { get; set; } = new int[2] { 83, 163 };
        public static int[] MonthlySunshineHours { get; set; } = new int[2] { 1452, 2112 };
        public static double[] Temperature24hAvgHighs { get; set; } = new double[2] { 19.5, 29.8 };
        public static double[] Temperature24hAvgLows { get; set; } = new double[2] { -4.8, 2.3 };
        public static double[] AnnualPM2_5Concentrations { get; set; } = new double[2] { 8.1, 20.1 };
        public static int[] CostOfLivingIndices { get; set; } = new int[2] { 42, 94 };

        public static int GdpPerCapitaHigh
        {
            get => (GdpPerCapitas[0] + 2 * GdpPerCapitas[1]) / 3;
        }
        public static int GdpPerCapitaLow
        {
            get => (2 * GdpPerCapitas[0] + GdpPerCapitas[1]) / 3;
        }
        public static double InequalityIndexHigh
        {
            get => (InequalityIndices[0] + 2.0 * InequalityIndices[1]) / 3.0;
        }
        public static double InequalityIndexLow
        {
            get => (2.0 * InequalityIndices[0] + InequalityIndices[1]) / 3.0;
        }
        public static int RainyDaysHigh
        {
            get => (RainyDays[0] + 2 * RainyDays[1]) / 3;
        }
        public static int RainyDaysLow
        {
            get => (2 * RainyDays[0] + RainyDays[1]) / 3;
        }
        public static int MonthlySunshineHoursHigh
        {
            get => (MonthlySunshineHours[0] + 2 * MonthlySunshineHours[1]) / 3;
        }
        public static int MonthlySunshineHoursLow
        {
            get => (2 * MonthlySunshineHours[0] + MonthlySunshineHours[1]) / 3;
        }
        public static double Temperature24hAvgHighHigh
        {
            get => (Temperature24hAvgHighs[0] + 2.0 * Temperature24hAvgHighs[1]) / 3.0;
        }
        public static double Temperature24hAvgHighLow
        {
            get => (2.0 * Temperature24hAvgHighs[0] + Temperature24hAvgHighs[1]) / 3.0;
        }
        public static double Temperature24hAvgLowHigh
        {
            get => (Temperature24hAvgLows[0] + 2.0 * Temperature24hAvgLows[1]) / 3.0;
        }
        public static double Temperature24hAvgLowLow
        {
            get => (2.0 * Temperature24hAvgLows[0] + Temperature24hAvgLows[1]) / 3.0;
        }
        public static double AnnualPM2_5ConcentrationHigh
        {
            get => (AnnualPM2_5Concentrations[0] + 2.0 * AnnualPM2_5Concentrations[1]) / 3.0;
        }
        public static double AnnualPM2_5ConcentrationLow
        {
            get => (2.0 * AnnualPM2_5Concentrations[0] + AnnualPM2_5Concentrations[1]) / 3.0;
        }
        public static int CostOfLivingIndexHigh
        {
            get => (GdpPerCapitas[0] + 2 * GdpPerCapitas[1]) / 3;
        }
        public static int CostOfLivingIndexLow
        {
            get => (2 * CostOfLivingIndices[0] + CostOfLivingIndices[1]) / 3;
        }

    }
}
