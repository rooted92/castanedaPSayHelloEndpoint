//Pedro Castaneda
//10-25-2022
//Say Hello - Endpoint
//Create a Controller with an endpoint and ask user for theri name. There input will be stored in a varaible and return a respose with their name included.
//Peer Review by; Lerissa Lazar, your program works well, outputs my name after "Hello" when i enter it in :) good job
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using castanedaPSayHelloEndpoint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPSayHelloEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet("Hello")]
        public string SayHello(SayHelloModel name)
        {
            bool checkWord = name.input.All(Char.IsLetter);
            string result = $"Hello {name.input}, nice to meet you!";
            if(!checkWord)
            {
                result = "Invalid Entry";
            }
            return result;
        }
    }
}