using CitySelection.WebApi.Models;
using CitySelection.WebApi.Models.Domains;
using CitySelection.WebApi.Models.Dtos;
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

        public City Select(QueryParams queryParams)
        {
            var allCities = _unitOfWork.Cities.Get();
            return new City();
        }

    }
}
