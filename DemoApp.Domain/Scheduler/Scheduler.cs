using AutoMapper;
using DemoApp.Data;
using DemoApp.Model;
using DemoApp.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Scheduler
{
    public class Scheduler : IScheduler
    {
        IApplicationDbContext context;
        private readonly IMapper mapper;
        public static bool IsCompleted = true;
        private readonly IOptions<UserAlbumsUrls> config;

        public Scheduler(IApplicationDbContext _context, IOptions<UserAlbumsUrls> _config, IMapper _mapper = null)
        {
            context = _context;
            mapper = _mapper;
            config = _config;
        }

        public async Task<UserInfoModel> CreateUser(UserInfoModel model)
        {
            try
            {
                UserInfo userInfo = mapper.Map<UserInfo>(model);
                await context.UserInfo.AddAsync(userInfo);
                context.SaveChanges();
                model = mapper.Map<UserInfoModel>(userInfo);
                return model;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public async Task<UserAlbumModel> CreateAlbum(UserAlbumModel model)
        {
            try
            {
                UserAlbum userAlbum = mapper.Map<UserAlbum>(model);
                await context.UserAlbum.AddAsync(userAlbum);
                context.SaveChanges();
                model = mapper.Map<UserAlbumModel>(userAlbum);
                return model;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public async Task<UserAlbumPhotoModel> CreateAlbumPhoto(UserAlbumPhotoModel model)
        {
            try
            {
                UserAlbumPhoto userAlbumPhoto = mapper.Map<UserAlbumPhoto>(model);
                await context.UserAlbumPhoto.AddAsync(userAlbumPhoto);
                context.SaveChanges();
                model = mapper.Map<UserAlbumPhotoModel>(userAlbumPhoto);
                return model;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public async Task<bool> ProcessUserAlbumScheduler()
        {
            try
            {
                if (IsCompleted)
                {
                    IsCompleted = false;
                    await FetchAllUsers();
                }
                return true;
            }
            catch (Exception Ex)
            {
                IsCompleted = true;
                return true;
            }
        }

        public async Task<bool> FetchAllUsers()
        {
            List<UserInfoModel> userList = await Get<UserInfoModel>(config.Value.UserURl);
            foreach (var user in userList)
            {
                try
                {
                    UserInfo userInfo = context.UserInfo.Where(x => x.id == user.id).FirstOrDefault();
                    if (userInfo != null)
                    {
                        userInfo.email = user.email;
                        userInfo.name = user.name;
                        userInfo.username = user.username;
                        userInfo.phone = user.phone;
                        userInfo.website = user.website;
                        context.SaveChanges();
                    }
                    else
                    {
                        UserInfoModel newUser = await CreateUser(user);
                    }

                    await FetchAllAlbums(user.id.ToString());
                }
                catch (Exception Ex)
                {

                    throw;
                }
                
            }
            return true;
        }

        public async Task<bool> FetchAllAlbums(string userId)
        {
            string url = config.Value.UserAlbumURl + userId;
            List<UserAlbumModel> userAlbumList = await Get<UserAlbumModel>(url);
            foreach (var album in userAlbumList)
            {
                UserAlbum userAlbum = context.UserAlbum.Where(x => x.id == album.id && x.userId == album.userId).FirstOrDefault();
                if (userAlbum != null)
                {
                    userAlbum.title = album.title;
                    context.SaveChanges();
                }
                else
                {
                    UserAlbumModel newAlbum = await CreateAlbum(album);
                }

                await FetchAllAlbumPhotos(album.id.ToString());
            }

            return true;
        }

        public async Task<bool> FetchAllAlbumPhotos(string albumId)
        {
            string url = config.Value.UserAlbumPhotoURl + albumId;
            List<UserAlbumPhotoModel> userAlbumPhotoList = await Get<UserAlbumPhotoModel>(url);
            foreach (var photo in userAlbumPhotoList)
            {
                UserAlbumPhoto userAlbumPhoto = context.UserAlbumPhoto.Where(x => x.id == photo.id && x.albumId == photo.albumId).FirstOrDefault();
                if (userAlbumPhoto != null)
                {
                    userAlbumPhoto.title = photo.title;
                    userAlbumPhoto.url = photo.url;
                    userAlbumPhoto.thumbnailUrl = photo.thumbnailUrl;
                    context.SaveChanges();
                }
                else
                {
                    UserAlbumPhotoModel newAlbum = await CreateAlbumPhoto(photo);
                }
            }
            return true;

        }

        public async Task<List<T>> Get<T>(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                string result1 = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<T>>(result1);
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

    }
}
