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
    public class LeaderboardRecordController : Controller
    {
        private MainDbContext db = new MainDbContext();

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Leaderboard/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeaderboardRecord leaderBoardRecord)
        {
            var username = User.Identity.Name;
            var id = User.Identity.GetUserId();
            //if(id != null)
            //    post.CreatedById = id;

            string currentUserId = User.Identity.GetUserId();
            var UserDetail = db.UserDetails.FirstOrDefault(x => x.ApplicationIdentityId == currentUserId);

            leaderBoardRecord.RecordCreated = DateTime.Now;
            leaderBoardRecord.RecordHolder = UserDetail;

            if (ModelState.IsValid)
            {
                db.LeaderboardRecords.Add(leaderBoardRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leaderBoardRecord);
        }

    }
}