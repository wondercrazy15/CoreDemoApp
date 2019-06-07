using DemoApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Model
{
    public class UserInfoViewModel
    {
        public UserInfoModel userInfo { get; set; }
       
    }

    public class UserInfoModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        //public string address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        //public string company { get; set; }
        public List<UserAlbumModel> userAlbumModels { get; set; } = new List<UserAlbumModel>();
        public List<UserAlbumPhotoModel> userAlbumPhotoModels { get; set; } = new List<UserAlbumPhotoModel>();
    }
    public class UserAlbumModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
    }

    public class UserAlbumPhotoModel
    {
        public int id { get; set; }
        public int albumId { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
