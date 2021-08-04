using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Domains
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // international dollars, 2021, IMF
        public int GdpPerCapita { get; set; } 

        // see:https://en.wikipedia.org/wiki/List_of_countries_by_income_equality#EU27_countries
        public double InequalityIndex { get; set; }

        public ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new Collection<City>();
        }

    }
}
