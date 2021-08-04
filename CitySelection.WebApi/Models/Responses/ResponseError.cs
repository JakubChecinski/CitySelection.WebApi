using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Responses
{
    public class ResponseError
    {
        public ResponseError(string source, string message)
        {
            Source = source;
            Message = message;
        }
        public string Source { get; set; }
        public string Message { get; set; }
    }
}
