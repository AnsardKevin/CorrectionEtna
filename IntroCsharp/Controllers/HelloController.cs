using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HelloControllers.Controllers
{
    [Route("home/hello")]
    [ApiController]
    public class helloController
    {   public class Account   {   
        public string Etna { get; set; }
    }

        [HttpGet]
        public string hello(string text)
        {
            Account acc = new Account
            {
                Etna = "Hello World"
            };  

            string json = JsonConvert.SerializeObject(acc, Formatting.Indented);

            return json;
            
        }
    }
}