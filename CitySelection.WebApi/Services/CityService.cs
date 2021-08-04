using CitySelection.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Services
{
    public class CityService
    {
        private UnitOfWork _unitOfWork;
        public CityService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Get()
        {
            _unitOfWork.Cities.Get();
        }

    }
}
