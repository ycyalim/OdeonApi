using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeonApi.Definitions.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlacesController : ControllerBase
    {

        [HttpGet]
        public List<string> Get(int countryId,string countryCode)
        {
            return new List<string>() { "Turkey", "Spaing", "Grece" };
        }
    }
}
