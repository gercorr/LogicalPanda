using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.DbContexts;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class BaseController : Controller
    {
        protected MainDbContext db = new MainDbContext();
        public UserDetail GetCurrentUserDetail()
        {
            var username = User.Identity.Name;
            string currentUserId = User.Identity.GetUserId();
            var UserDetail = db.UserDetails.FirstOrDefault(x => x.ApplicationIdentityId == currentUserId);


            return UserDetail;
        }
        
    }
}