using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Domains
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string EnglishName { get; set; }
        public int Population { get; set; }
        public string WikipediaUrl { get; set; }

        // see https://www.eea.europa.eu/themes/air/urban-air-quality/european-city-air-quality-viewer
        public double AnnualPM2_5Concentration { get; set; }

        // see https://www.numbeo.com/cost-of-living/gmaps.jsp
        public int CostOfLivingIndex { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        // one-to-one relationship - no id included here
        // see: https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#other-relationship-patterns
        public Climate Climate { get; set; }

    }
}
