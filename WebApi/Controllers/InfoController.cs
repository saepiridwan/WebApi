using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class InfoController : ApiController
    {
        [HttpPost]
        public Response AdddInfo(InfoRequest request)
        {
            Response response = new Response();

            // Do some operation here
            return response;
        }

        public class Response
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }

        public class InfoRequest
        {
            public string Name { get; set; }
        }
    }
}
