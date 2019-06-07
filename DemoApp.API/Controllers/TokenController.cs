using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.API.Helper;
using DemoApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.API.Controllers
{
    [ApiController]
    public class TokenController : ControllerBase
    {
        [Route("token")]
        [HttpGet]
        public IActionResult Create()
        {
           var token = new JwtTokenBuilder()
                                .AddSecurityKey(JwtSecurityKey.Create("this is my custom Secret key for authnetication"))
                                .AddSubject("Username Password")
                                .AddIssuer("Fiver.Security.Bearer")
                                .AddAudience("Fiver.Security.Bearer")
                                .AddClaim("MembershipId", "111")
                                .AddExpiry(60)
                                .Build();

            return Ok(token.Value);
        }
    }
}