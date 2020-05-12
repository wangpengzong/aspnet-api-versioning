﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoVersioningAndSupportAreaSample.Areas.User.V1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoVersioningAndSupportAreaSample.Areas.User.V1.Controllers
{
    [ApiController]
    [Area( "User" )]
    [ApiVersion( "1.0" )]
    [Route( "[area]/[controller]" )]
    public class OrdersController : ControllerBase
    {
        [HttpGet( "{accountId}" )]
        public IActionResult Get( string accountId, ApiVersion apiVersion ) => Ok( new Order( GetType().FullName, accountId, apiVersion.ToString() ) );

    }
}