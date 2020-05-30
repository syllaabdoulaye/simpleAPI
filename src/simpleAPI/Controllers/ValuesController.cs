using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace simpleAPI.Controllers
{
    [ApiController]
    [Route("api/values")]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
           
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string [] {"value1","value2"};
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Adama";
        }

    }
}
