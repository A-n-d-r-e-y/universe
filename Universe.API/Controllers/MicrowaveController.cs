﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Universe.Engine;

namespace Universe.API.Controllers
{
    public class MicrowaveController : ApiController
    {
        Microwave[] microwave = new Microwave[]
        {
            new Microwave(),
        };

        public IEnumerable<Microwave> Get()
        {
            return microwave;
        }

        //public IHttpActionResult GetProduct(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
    }
}
