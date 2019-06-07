using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoApp.Domain.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Web.Controllers
{
    [Authorize]
    public class UserAlbumController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserAlbumnInfoService _userInfo;
        public UserAlbumController(IUserAlbumnInfoService userInfo, IMapper mapper)
        {
            _userInfo = userInfo;
            _mapper = mapper;
        }

      
        [HttpGet]
        public IActionResult Index()
        {
            var userInfo = _userInfo.GetUserInfo();
            return View(userInfo);
        }
    }
}