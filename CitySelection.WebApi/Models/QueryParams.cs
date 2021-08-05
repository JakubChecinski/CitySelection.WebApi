using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models
{
    public class QueryParams
    {
        // convention: first index is for variable, second one is for: importance = 0, preference = 1
        public int[,] CityParams { get; set; }

    }
}
