using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApp.DbContexts;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class LeaderboardRecord
    {

        public int Id { get; set; }
        
        public DateTime RecordCreated { get; set; }
        public int Score { get; set; }

        [ForeignKey("RecordHolder")]
        public int? UserDetailId { get; set; }
        
        public virtual UserDetail RecordHolder { get; set; }

        [ForeignKey("Leaderboard")]
        public int LeaderboardId { get; set; }
        
        public virtual Leaderboard Leaderboard { get; set; }


    }

}