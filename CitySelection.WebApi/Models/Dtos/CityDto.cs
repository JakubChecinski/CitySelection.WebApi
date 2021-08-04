using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Dtos
{
    public class CityDto
    {
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public string WikipediaUrl { get; set; }


    }
}
