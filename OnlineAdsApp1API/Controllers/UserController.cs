using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineAdsApp1API.Models;
using OnlineAdsApp.BL;

namespace OnlineAdsApp1API.Controllers
{
    public class UserController : ApiController
    {
        UserService ObjUserService;

        public UserController()
        {
            ObjUserService = new UserService();
        }
        public IHttpActionResult Get()
        {
            List <UserBindingModel> Users= new List<UserBindingModel>();
            try
            {
                var objUsers = ObjUserService.GetAllUsers();
                foreach (var item in objUsers)
                {
                    Users.Add(new UserBindingModel()
                    {
                        UserId = item.UserId,
                        UserName = item.UserName,
                        EmailId = item.EmailId,
                        PhoneNo = item.PhoneNo
                    });
                }
                return Json(Users);
            }
            catch(Exception e)
            {
                return InternalServerError();
            }
        }
    }
}
