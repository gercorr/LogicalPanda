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
    public class Leaderboard
    {
        
        public int Id { get; set; }
        
        public DateTime Created { get; set; }
        public string Game { get; set; }

        [ForeignKey("CreatedBy")]
        public int? UserDetailId { get; set; }

        [DisplayName("Created By")]
        public virtual UserDetail CreatedBy { get; set; }


        public virtual ICollection<LeaderboardRecord> LeaderboardRecords { get; set; }

    }

}