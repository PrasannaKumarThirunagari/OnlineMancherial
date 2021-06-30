using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM_DataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonServiceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
