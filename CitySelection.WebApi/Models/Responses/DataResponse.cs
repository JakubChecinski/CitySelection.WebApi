using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Responses
{
    public class DataResponse<T> : Response
    {
        public T Data { get; set; }
    }
}
