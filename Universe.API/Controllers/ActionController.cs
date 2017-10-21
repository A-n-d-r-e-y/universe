using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Universe.API.Controllers
{
    public class ActionController : ApiController
    {
        // GET: api/Action
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Action/5
        public string Get(int id)
        {
            return "value" + id.ToString();
        }

        // POST: api/Action
        public void Post([FromBody]string value)
        {
        }
    }
}
