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
    public class Post
    {

        private MainDbContext db = new MainDbContext();

        public int Id { get; set; }
        
        [DisplayName("Created")]
        public DateTime Date { get; set; }
        public string Title { get; set; }
        
        [DisplayName("Comment")]
        public string Content { get; set; }

        [ForeignKey("UserDetail")]
        public int? UserDetailId { get; set; }

        public virtual UserDetail UserDetail { get; set; }


    }

}