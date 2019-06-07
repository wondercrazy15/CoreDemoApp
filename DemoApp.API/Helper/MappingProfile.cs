using AutoMapper;
using DemoApp.Data;
using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.API.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<UserInfo, UserInfoModel>();
            CreateMap<UserAlbum, UserAlbumModel>();
            CreateMap<UserAlbumPhoto, UserAlbumPhotoModel>();
        }
    }
}
