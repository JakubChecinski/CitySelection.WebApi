using CitySelection.WebApi.Models.Domains;
using CitySelection.WebApi.Models.Dtos;
using CitySelection.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Converters
{
    public static class CityConverter
    {
        public static CityDto ToDto(this City model)
        {
            return new CityDto()
            {
                Name = model.Name,
                EnglishName = model.EnglishName,
                Country = model.Country.Name,
                Population = model.Population,
                WikipediaUrl = model.WikipediaUrl,
            };
        }

        public static CityAsCodes ToCityAsCodes(this City model)
        {
            return new CityAsCodes()
            {
                CityId = model.Id,

                GdpPerCapita =
                model.Country.GdpPerCapita > DataHelper.GdpPerCapitaHigh ? 3 :
                model.Country.GdpPerCapita > DataHelper.GdpPerCapitaLow ? 2 : 1,
                InequalityIndex =
                model.Country.InequalityIndex > DataHelper.InequalityIndexHigh ? 3 :
                model.Country.InequalityIndex > DataHelper.InequalityIndexLow ? 2 : 1,
                RainyDays =
                model.Climate.RainyDays > DataHelper.RainyDaysHigh ? 3 :
                model.Climate.RainyDays > DataHelper.RainyDaysLow ? 2 : 1,
                MonthlySunshineHours =
                model.Climate.MonthlySunshineHours > DataHelper.MonthlySunshineHoursHigh ? 3 :
                model.Climate.MonthlySunshineHours > DataHelper.MonthlySunshineHoursLow ? 2 : 1,
                Temperature24hAvgHigh =
                model.Climate.Temperature24hAvgHigh > DataHelper.Temperature24hAvgHighHigh ? 3 :
                model.Climate.Temperature24hAvgHigh > DataHelper.Temperature24hAvgHighLow ? 2 : 1,
                Temperature24hAvgLow =
                model.Climate.Temperature24hAvgLow > DataHelper.Temperature24hAvgLowHigh ? 3 :
                model.Climate.Temperature24hAvgLow > DataHelper.Temperature24hAvgLowLow ? 2 : 1,
                AnnualPM2_5Concentration =
                model.AnnualPM2_5Concentration > DataHelper.AnnualPM2_5ConcentrationHigh ? 3 :
                model.AnnualPM2_5Concentration > DataHelper.AnnualPM2_5ConcentrationLow ? 2 : 1,
                CostOfLivingIndex =
                model.CostOfLivingIndex > DataHelper.CostOfLivingIndexHigh ? 3 :
                model.CostOfLivingIndex > DataHelper.CostOfLivingIndexLow ? 2 : 1,
            };
        }

    }
}
