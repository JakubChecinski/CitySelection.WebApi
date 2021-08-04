using CitySelection.WebApi.Models;
using CitySelection.WebApi.Models.Converters;
using CitySelection.WebApi.Models.Domains;
using CitySelection.WebApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CitySelection.WebApi.Services
{
    public class CityService
    {
        private UnitOfWork _unitOfWork;
        public CityService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public City Select(QueryParams qp)
        {
            var cities = _unitOfWork.Cities.Get().Select(x => x.ToCityAsCodes());
            cities = VerifyMandatoryConditions(cities, qp);
            return _unitOfWork.Cities.Get(
                cities.OrderByDescending(x => CalculateDesirability(x, qp)).First().CityId);
        }
        private IEnumerable<CityAsCodes> VerifyMandatoryConditions
            (IEnumerable<CityAsCodes> cities, QueryParams qp)
        {
            if (qp.GdpPerCapita[0] == 3) cities = cities.Where(x => x.GdpPerCapita == qp.GdpPerCapita[1]);
            if (qp.InequalityIndex[0] == 3) cities = cities.Where(x => x.InequalityIndex == qp.InequalityIndex[1]);
            if (qp.RainyDays[0] == 3) cities = cities.Where(x => x.RainyDays == qp.RainyDays[1]);
            if (qp.MonthlySunshineHours[0] == 3) cities = cities.Where(x => x.MonthlySunshineHours == qp.MonthlySunshineHours[1]);
            if (qp.Temperature24hAvgHigh[0] == 3) cities = cities.Where(x => x.Temperature24hAvgHigh == qp.Temperature24hAvgHigh[1]);
            if (qp.Temperature24hAvgLow[0] == 3) cities = cities.Where(x => x.Temperature24hAvgLow == qp.Temperature24hAvgLow[1]);
            if (qp.AnnualPM2_5Concentration[0] == 3) cities = cities.Where(x => x.AnnualPM2_5Concentration == qp.AnnualPM2_5Concentration[1]);
            if (qp.CostOfLivingIndex[0] == 3) cities = cities.Where(x => x.CostOfLivingIndex == qp.CostOfLivingIndex[1]);
            return cities;
        }
        private int CalculateDesirability(CityAsCodes x, QueryParams qp)
        {
            return qp.GdpPerCapita[0] * Math.Abs(x.GdpPerCapita - qp.GdpPerCapita[1]) +
                qp.InequalityIndex[0] * Math.Abs(x.InequalityIndex - qp.InequalityIndex[1]) +
                qp.RainyDays[0] * Math.Abs(x.RainyDays - qp.RainyDays[1]) +
                qp.MonthlySunshineHours[0] * Math.Abs(x.MonthlySunshineHours - qp.MonthlySunshineHours[1]) +
                qp.Temperature24hAvgHigh[0] * Math.Abs(x.Temperature24hAvgHigh - qp.Temperature24hAvgHigh[1]) +
                qp.Temperature24hAvgLow[0] * Math.Abs(x.Temperature24hAvgLow - qp.Temperature24hAvgLow[1]) +
                qp.AnnualPM2_5Concentration[0] * Math.Abs(x.AnnualPM2_5Concentration - qp.AnnualPM2_5Concentration[1]) +
                qp.CostOfLivingIndex[0] * Math.Abs(x.CostOfLivingIndex - qp.CostOfLivingIndex[1]);
        }

    }
}
