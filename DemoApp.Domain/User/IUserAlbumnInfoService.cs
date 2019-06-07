using DemoApp.Data;
using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Domain.User
{
    public interface IUserAlbumnInfoService
    {
        List<UserInfoModel> GetUserInfo();
    }
}
