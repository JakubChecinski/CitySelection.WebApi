using CitySelection.WebApi.Models.Domains;
using CitySelection.WebApi.Models.Dtos;
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
    }
}
