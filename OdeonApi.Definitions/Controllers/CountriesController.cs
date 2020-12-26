using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeonApi.Definitions.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {

        [HttpGet]
        public List<string> Get(int countryId,string languageCode)
        {
            return new List<string>() { "Turkey", "Spaing", "Grece" };
        }
    }
}
