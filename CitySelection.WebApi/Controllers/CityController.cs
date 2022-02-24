using CitySelection.WebApi.Models;
using CitySelection.WebApi.Models.Dtos;
using CitySelection.WebApi.Models.Responses;
using CitySelection.WebApi.Services;
using CitySelection.WebApi.Models.Converters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CitySelection.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        private CityService _cityService { get; }
        public CityController(CityService cityService, ILogger<CityController> logger)
        {
            _cityService = cityService;
            _logger = logger;
        }


        /// <summary>
        /// Get the city which is the most compatible with your submitted preferences
        /// </summary>
        /// <param name="queryParams">An object containing preferences stored as integers (see also the example)</param>
        /// <returns>DataResponse object with CityDto stored in Data property (see also the example)</returns>
        /// <example>
        /// Submitted JSON:
        /// {
        ///     "GdpPerCapitaImportance" : 2,
        ///     "GdpPerCapitaPreference" : 2,
        ///     "InequalityIndexImportance" : 1,
        ///     "InequalityIndexPreference" : 1,
        ///     "RainyDaysImportance" : 0,
        ///     "RainyDaysPreference" : 0,
        ///     "MonthlySunshineHoursImportance" : 1,
        ///     "MonthlySunshineHoursPreference" : 3,
        ///     "Temperature24hAvgHighImportance" : 1,
        ///     "Temperature24hAvgHighPreference" : 1,
        ///     "Temperature24hAvgLowImportance" : 2,
        ///     "Temperature24hAvgLowPreference" : 1,
        ///     "AnnualPM2_5ConcentrationImportance" : 3,
        ///     "AnnualPM2_5ConcentrationPreference" : 1,
        ///     "CostOfLivingIndexImportance" : 2,
        ///     "CostOfLivingIndexPreference" : 1
        /// }
        /// Received JSON:
        /// {
        ///     "data": {
        ///         "name": "München",
        ///         "englishName": "Munich",
        ///         "country": "Germany",
        ///         "population": 2606,
        ///         "wikipediaUrl": "https://en.wikipedia.org/wiki/Munich"
        ///         },
        ///     "errors": [],
        ///     "isSuccess": true
        /// }
        /// </example>
        /// <remarks>
        /// Importance codes are as following:
        ///     Irrelevant = 0
        ///     NiceToHave = 1
        ///     Important = 2
        ///     Mandatory = 3
        /// Preference codes are as following:
        ///     N/A = 0
        ///     Low = 1
        ///     Medium = 2
        ///     High = 3
        /// Other codes will result in throwing an exception.
        /// 
        /// If the importance code is set to irrelevant, the preference code will be ignored.
        /// For the sake of clarity, it is recommended to use N/A (zero).
        /// </remarks>
        [HttpGet]
        public DataResponse<CityDto> FindMostCompatible(QueryParamsDto queryParams)
        {
            var response = new DataResponse<CityDto>();
            try
            {
                response.Data = _cityService.Select(queryParams.ToDao())?.ToDto();
            }
            catch (Exception exc)
            {
                _logger.LogError(exc.Message);
                response.Errors.Add(new ResponseError(exc.Source, exc.Message));
            }
            return response;
        }

    }
}
