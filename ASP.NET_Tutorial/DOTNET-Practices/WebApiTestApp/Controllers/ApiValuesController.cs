using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTestApp.Controllers
{
    public class ApiValuesController : ApiController
    {
        [Route("api/GetEmp/{id}")]
        public IHttpActionResult Get([FromUri]int id)
        {
            return Ok(1);
        }
    }
}
