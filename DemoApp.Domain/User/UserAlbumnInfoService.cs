using DemoApp.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DemoApp.Model;
using AutoMapper;

namespace DemoApp.Domain.User
{
    public class UserAlbumnInfoService : IUserAlbumnInfoService
    {
        private DemoAppContext _context;
        private readonly IMapper _mapper;
        public UserAlbumnInfoService(DemoAppContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<UserInfoModel> GetUserInfo()
        {
            List<UserInfoModel> userInfoViewModels = new List<UserInfoModel>();
            var userInfo = (from u in _context.UserInfo
                            select u).ToList();
            if(userInfo != null)
            {
                var userInfoModel = _mapper.Map<List<UserInfoModel>>(userInfo);

                foreach (var item in userInfoModel)
                {
                    var album = _context.UserAlbum.Where(x => x.userId == item.id).ToList();
                    if (album != null)
                    {
                        var albumList = _mapper.Map<List<UserAlbumModel>>(album);
                        item.userAlbumModels = albumList;
                        foreach (var photoItem in albumList)
                        {
                            var photo = _context.UserAlbumPhoto.Where(x => x.albumId == photoItem.id).ToList();
                            var photoList = _mapper.Map<List<UserAlbumPhotoModel>>(photo);
                            if (photoList.Count() > 0)
                            {
                                item.userAlbumPhotoModels.AddRange(photoList);
                            }
                        }
                    }
                }
                userInfoViewModels = userInfoModel;
            }
            return userInfoViewModels;
        }
    }
}
