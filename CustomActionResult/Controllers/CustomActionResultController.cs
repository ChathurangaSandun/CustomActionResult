using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomActionResult.CustomAction;

namespace CustomActionResult.Controllers
{
    [Route("api/[controller]")]
    public class CustomActionResultController : Controller
    {
        [HttpGet]
        public StringWriterResult Get()
        {
            return new StringWriterResult("sandun");
        }
    }
}