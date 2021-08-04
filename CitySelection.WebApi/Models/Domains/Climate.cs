using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Domains
{
    public class Climate
    {
        [Key]
        public int Id { get; set; }

        public double Temperature24hAvgHigh { get; set; }
        public double Temperature24hAvgLow { get; set; }
        public int RainyDays { get; set; }
        public int MonthlySunshineHours { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
