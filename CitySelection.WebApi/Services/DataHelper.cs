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

    }
}
