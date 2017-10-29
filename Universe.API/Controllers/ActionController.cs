using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Universe.API.Models;
using Universe.Engine;

namespace Universe.API.Controllers
{
    public class ActionController : ApiController
    {
        // GET: api/Action
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Action/5
        //public string Get(int actionId)
        //{
        //    return "value" + actionId.ToString();
        //}

        // POST: api/Action
        public IHttpActionResult Post([FromBody]MicrowaveAction value)
        {
            if (value == null)
            {
                return BadRequest("Item cannot be null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mw = new Microwave();

            switch (value.ActionName)
            {
                case "OpenTheDoor":
                    mw.OpenTheDoor();
                    break;
                case "PressTheButton":
                    mw.PressTheButton();
                    break;
                case "CloseTheDoor":
                    mw.CloseTheDoor();
                    break;
                default:
                    break;
            }

            return Ok(mw);
        }
    }
}
