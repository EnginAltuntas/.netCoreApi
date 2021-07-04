using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCoreProject.Controllers
{
    [Route("Products")]
    public class Products:ControllerBase
    {

        [Route("Merhaba")]
        public string Merhaba()
        {
            return "Merhaba endpoint";
        }

        [Route("Hello")]
        public string Hello()
        {
            return "Hello endpoint";
        }

    }
}
