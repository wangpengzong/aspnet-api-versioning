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
    public class OrdersController : ControllerBase
    {
        // GET ~/orders/{accountId}
        [HttpGet( "{accountId}" )]
        public IActionResult Get( string accountId, ApiVersion apiVersion ) => Ok( new Order( GetType().FullName, accountId, apiVersion.ToString() ) );
    }
}