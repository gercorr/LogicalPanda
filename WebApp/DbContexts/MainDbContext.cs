using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApp.Models;

namespace WebApp.DbContexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("MainDbConnection")
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Leaderboard> Leaderboards { get; set; }
        public DbSet<LeaderboardRecord> LeaderboardRecords { get; set; }

    }
}