using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoVersioningAndSupportAreaSample.V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoVersioningAndSupportAreaSample.V2.Controllers
{
    [ApiController]
    [ApiVersion( "2.0" )]
    [Route( "[controller]" )]
    public class TestController : ControllerBase
    {
        // GET ~/test/{accountId}
        [HttpGet( "{accountId}" )]
        public IActionResult Get( string accountId, ApiVersion apiVersion ) => Ok( new Test( GetType().FullName, accountId, apiVersion.ToString() ) );

    }
}