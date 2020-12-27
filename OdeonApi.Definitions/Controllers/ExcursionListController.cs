<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeonApi.Definitions.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ExcursionListController : ControllerBase
    {

        [HttpGet]
        public List<string> Get(int countryId,string languageCode)
        {
            return new List<string>() { "Antalya", "Muğla", "İzmir" };
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeonApi.Definitions.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ExcursionListController : ControllerBase
    {

        [HttpGet]
        public List<string> Get(int countryId,string languageCode)
        {
            return new List<string>() { "Antalya", "Muğla", "İzmir" };
        }
    }
}
>>>>>>> 8e7e67b539f633f81d8b86aacc0abc8e57af6de9
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeonApi.Definitions.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ExcursionListController : ControllerBase
    {

        [HttpGet]
        public List<string> Get(int countryId,string languageCode)
        {
            return new List<string>() { "Antalya", "Muğla", "İzmir" };
        }
    }
}
>>>>>>> 8e7e67b539f633f81d8b86aacc0abc8e57af6de9
