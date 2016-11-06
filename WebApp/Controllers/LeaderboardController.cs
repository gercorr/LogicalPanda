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
    public class LeaderboardController : BaseController
    {
        // GET: Leaderboard
        public ActionResult Index()
        {
            return View(db.Leaderboards.ToList());
        }

        //
        // GET: /Leaderboard/Details/5

        public ActionResult Details(int id = 0)
        {
            Leaderboard leaderBoard = db.Leaderboards.Find(id);
            if (leaderBoard == null)
            {
                return HttpNotFound();
            }
            return View(leaderBoard);
        }

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Leaderboard/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Leaderboard leaderBoard)
        {

            leaderBoard.Created = DateTime.Now;
            leaderBoard.CreatedBy = GetCurrentUserDetail();

            if (ModelState.IsValid)
            {
                db.Leaderboards.Add(leaderBoard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leaderBoard);
        }
        public ActionResult Delete(int id = 0)
        {
            Leaderboard leaderBoard = db.Leaderboards.Find(id);
            if (leaderBoard == null)
            {
                return HttpNotFound();
            }
            return View(leaderBoard);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Leaderboard leaderBoard = db.Leaderboards.Find(id);
            db.Leaderboards.Remove(leaderBoard);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateRecord()
        {
            return View();
        }

        //
        // POST: /Leaderboard/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRecord(int leaderBoardId, LeaderboardRecord leaderBoardRecord)
        {
            leaderBoardRecord.LeaderboardId = leaderBoardId;
            leaderBoardRecord.RecordCreated = DateTime.Now;
            leaderBoardRecord.RecordHolder = GetCurrentUserDetail();

            if (ModelState.IsValid)
            {
                db.LeaderboardRecords.Add(leaderBoardRecord);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = leaderBoardId });
            }

            return View(leaderBoardRecord);
        }

    }
}