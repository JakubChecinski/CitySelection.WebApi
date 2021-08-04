using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Responses
{
    public class Response
    {
        public Response()
        {
            Errors = new List<ResponseError>();
        }
        public List<ResponseError> Errors { get; set; }
        public bool IsSuccess => Errors != null && !Errors.Any();

    }
}
