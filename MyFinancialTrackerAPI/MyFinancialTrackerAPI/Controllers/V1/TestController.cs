using Microsoft.AspNetCore.Mvc;
using MyFinancialTrackerAPI.Contracts.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinancialTrackerAPI.Controllers.V1
{
    public class TestController : Controller
    {
        [HttpGet(ApiRoutes.Test.GetAll)]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
