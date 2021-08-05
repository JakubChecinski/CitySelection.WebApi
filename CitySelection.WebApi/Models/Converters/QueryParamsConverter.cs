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
            // either size is hardcoded or I need to use reflection 
            // can't think of a third option as of now
            var dao = new QueryParams() { 
                CityParams = new int[typeof(QueryParamsDto).GetProperties().Count() / 2, 2] };
                //CityParams = new int[8, 2] };

            switch (model.GdpPerCapitaImportance)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    dao.CityParams[0, 0] = model.GdpPerCapitaImportance;
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
                    dao.CityParams[0, 1] = model.GdpPerCapitaPreference;
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
                    dao.CityParams[1, 0] = model.InequalityIndexImportance;
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
                    dao.CityParams[1, 1] = model.InequalityIndexPreference;
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
                    dao.CityParams[2, 0] = model.RainyDaysImportance;
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
                    dao.CityParams[2, 1] = model.RainyDaysPreference;
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
                    dao.CityParams[3, 0] = model.MonthlySunshineHoursImportance;
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
                    dao.CityParams[3, 1] = model.MonthlySunshineHoursPreference;
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
                    dao.CityParams[4, 0] = model.Temperature24hAvgHighImportance;
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
                    dao.CityParams[4, 1] = model.Temperature24hAvgHighPreference;
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
                    dao.CityParams[5, 0] = model.Temperature24hAvgLowImportance;
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
                    dao.CityParams[5, 1] = model.Temperature24hAvgLowPreference;
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
                    dao.CityParams[6, 0] = model.AnnualPM2_5ConcentrationImportance;
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
                    dao.CityParams[6, 1] = model.AnnualPM2_5ConcentrationPreference;
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
                    dao.CityParams[7, 0] = model.CostOfLivingIndexImportance;
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
                    dao.CityParams[7, 1] = model.CostOfLivingIndexPreference;
                    break;
                default:
                    throw new ArgumentException("CostOfLivingIndexPreference code outside of range.");
            }
            return dao;
        }
    }
}
