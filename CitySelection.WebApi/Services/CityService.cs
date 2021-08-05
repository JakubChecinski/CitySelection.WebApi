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
            if (cities.Count() == 0) return null;
            return _unitOfWork.Cities.Get(
                cities.OrderBy(x => CalculateCompatibility(x, qp)).First().CityId);
        }
        private IEnumerable<CityAsCodes> VerifyMandatoryConditions(IEnumerable<CityAsCodes> cities, QueryParams qp)
        {
            for (int i = 0; i < qp.CityParams.GetLength(0); i++)
            {
                // there is a LINQ issue where lazy evaluation sometimes gets too lazy 
                // and doesn't evaluate Where conditions until the loop index is incremented to outside of bounds
                // so this will result in an error:
                // if (qp.CityParams[i, 0] == 3) cities = cities.Where(x => x.CityData[i] == qp.CityParams[i, 1]);
                // i = 0, 1, ..., N-1: LINQ does nothing
                // i = N, we exit the loop and return: now LINQ wakes up and wants to evaluate Where condition
                // "Index was outside the bounds of the array."

                // a really funny solution is to decouple the query variable from the loop variable, like this:
                var j = i;
                if (qp.CityParams[j, 0] == 3) cities = cities.Where(x => x.CityData[j] == qp.CityParams[j, 1]);
            }
            return cities;
        }
        private int CalculateCompatibility(CityAsCodes x, QueryParams qp)
        {
            int compatibilityScore = 0;  // note: lower score is better
            for (int i = 0; i < qp.CityParams.GetLength(0); i++)
            {
                compatibilityScore += qp.CityParams[i, 0] * Math.Abs(x.CityData[i] - qp.CityParams[i, 1]);
            }
            return compatibilityScore;
        }

    }
}
