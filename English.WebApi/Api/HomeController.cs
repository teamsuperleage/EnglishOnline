using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace English.WebApi.Api
{
    [RoutePrefix("api/home")]

    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("TestMethod")]
        public string TestMethod()
        {
            return "Hello, English Member. ";
        }
    }
}