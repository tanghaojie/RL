using Abp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RLCore.Web.Host.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : RLCoreWebHostControllerBase
    {
        [HttpGet]
        [Authorize]
        public string X()
        {
            return "TestHost";
        }

        [HttpPost]
        [Authorize]
        public string P([FromBody] AuthenticateModel model)
        {
            return "TestHost";
        }


    }
}
