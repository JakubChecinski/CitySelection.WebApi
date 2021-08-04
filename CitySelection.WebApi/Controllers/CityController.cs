﻿using CitySelection.WebApi.Models;
using CitySelection.WebApi.Models.Dtos;
using CitySelection.WebApi.Models.Responses;
using CitySelection.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private CityService _cityService { get; }
        public CityController(CityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost]
        public DataResponse<CityDto> Select()
        {
            var response = new DataResponse<CityDto>();
            try
            {
                response.Data = null;// cityService.Get()?.ToDto();
            }
            catch (Exception e)
            {
                // logowanie bledu
                response.Errors.Add(new ResponseError(e.Source, e.Message));
            }
            return response;
        }

    }
}
