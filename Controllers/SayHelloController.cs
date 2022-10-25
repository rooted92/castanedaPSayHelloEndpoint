//Pedro Castaneda
//10-25-2022
//Say Hello - Endpoint
//Create a Controller with an endpoint and ask user for theri name. There input will be stored in a varaible and return a respose with their name included.
//Peer Review by; 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPSayHelloEndpoint.Controllers
{
    [Route("[controller]")]
    public class SayHelloController : Controller
    {
        [HttpGet]
        [Route("Hello/{name}")]
        public string SayHello(string name)
        {
            return $"Hello {name}";
        }
    }
}