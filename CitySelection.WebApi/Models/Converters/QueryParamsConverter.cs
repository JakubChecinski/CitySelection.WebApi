using CitySelection.WebApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Converters
{
    public static class QueryParamsConverter
    {
        public static QueryParams ToDao(this QueryParamsDto model)
        {
            var dao = new QueryParams();
            switch (model.GdpPerCapitaImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.GdpPerCapita[0] = model.GdpPerCapitaImportance;
                    break;
                default:
                    throw new ArgumentException("GdpPerCapitaImportance code outside of range.");
            }
            switch (model.GdpPerCapitaPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.GdpPerCapita[1] = model.GdpPerCapitaPreference;
                    break;
                default:
                    throw new ArgumentException("GdpPerCapitaPreference code outside of range.");
            }
            switch (model.InequalityIndexImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.InequalityIndex[0] = model.InequalityIndexImportance;
                    break;
                default:
                    throw new ArgumentException("InequalityIndexImportance code outside of range.");
            }
            switch (model.InequalityIndexPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.InequalityIndex[1] = model.InequalityIndexPreference;
                    break;
                default:
                    throw new ArgumentException("InequalityIndexPreference code outside of range.");
            }
            switch (model.RainyDaysImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.RainyDays[0] = model.RainyDaysImportance;
                    break;
                default:
                    throw new ArgumentException("RainyDaysImportance code outside of range.");
            }
            switch (model.RainyDaysPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.RainyDays[1] = model.RainyDaysPreference;
                    break;
                default:
                    throw new ArgumentException("RainyDaysPreference code outside of range.");
            }
            switch (model.MonthlySunshineHoursImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.MonthlySunshineHours[0] = model.MonthlySunshineHoursImportance;
                    break;
                default:
                    throw new ArgumentException("MonthlySunshineHoursImportance code outside of range.");
            }
            switch (model.MonthlySunshineHoursPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.MonthlySunshineHours[1] = model.MonthlySunshineHoursPreference;
                    break;
                default:
                    throw new ArgumentException("MonthlySunshineHoursPreference code outside of range.");
            }
            switch (model.Temperature24hAvgHighImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.Temperature24hAvgHigh[0] = model.Temperature24hAvgHighImportance;
                    break;
                default:
                    throw new ArgumentException("Temperature24hAvgHighImportance code outside of range.");
            }
            switch (model.Temperature24hAvgHighPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.Temperature24hAvgHigh[1] = model.Temperature24hAvgHighPreference;
                    break;
                default:
                    throw new ArgumentException("Temperature24hAvgHighPreference code outside of range.");
            }
            switch (model.Temperature24hAvgLowImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.Temperature24hAvgLow[0] = model.Temperature24hAvgLowImportance;
                    break;
                default:
                    throw new ArgumentException("Temperature24hAvgLowImportance code outside of range.");
            }
            switch (model.Temperature24hAvgLowPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.Temperature24hAvgLow[1] = model.Temperature24hAvgLowPreference;
                    break;
                default:
                    throw new ArgumentException("Temperature24hAvgLowPreference code outside of range.");
            }
            switch (model.AnnualPM2_5ConcentrationImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.AnnualPM2_5Concentration[0] = model.AnnualPM2_5ConcentrationImportance;
                    break;
                default:
                    throw new ArgumentException("AnnualPM2_5ConcentrationImportance code outside of range.");
            }
            switch (model.AnnualPM2_5ConcentrationPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.AnnualPM2_5Concentration[1] = model.AnnualPM2_5ConcentrationPreference;
                    break;
                default:
                    throw new ArgumentException("AnnualPM2_5ConcentrationPreference code outside of range.");
            }
            switch (model.CostOfLivingIndexImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.CostOfLivingIndex[0] = model.CostOfLivingIndexImportance;
                    break;
                default:
                    throw new ArgumentException("CostOfLivingIndexImportance code outside of range.");
            }
            switch (model.CostOfLivingIndexPreference)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.CostOfLivingIndex[1] = model.CostOfLivingIndexPreference;
                    break;
                default:
                    throw new ArgumentException("CostOfLivingIndexPreference code outside of range.");
            }
            return dao;
        }
    }
}
