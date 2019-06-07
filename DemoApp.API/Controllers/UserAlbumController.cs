using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoApp.Domain.User;
using DemoApp.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.API.Controllers
{
   
    [ApiController]
    [Authorize]
    public class UserAlbumController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserAlbumnInfoService _userInfo;
        public UserAlbumController(IUserAlbumnInfoService userInfo, IMapper mapper)
        {
            _userInfo = userInfo;
            _mapper = mapper;
        }

        [Route("UserInfo")]
        [HttpGet]
        public IActionResult GetUserInfo()
        {
            var userInfo = _userInfo.GetUserInfo();
            return Ok(userInfo);
        }
    }
}