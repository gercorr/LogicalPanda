using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.DbContexts;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LeaderboardApiController : ApiController
    {
        protected MainDbContext db = new MainDbContext();
        // GET: api/WebApi
        public IEnumerable<Leaderboard> Get()
        {
            var arrayOfLeaderboards = db.Leaderboards.ToArray();
            return arrayOfLeaderboards;
        }

        // GET: api/LeaderboardApi?id=3
        public Leaderboard Get(int id)
        {
            return db.Leaderboards.FirstOrDefault(l => l.Id == id);
        }

        // GET: api/LeaderboardApi?name=ger
        public Leaderboard Get(string name)
        {
            return db.Leaderboards.FirstOrDefault(l => l.CreatedBy.UserName == name);
        }

        // GET: api/LeaderboardApi?id=3&name=ger
        public Leaderboard Get(int id, string name)
        {
            return db.Leaderboards.FirstOrDefault(l => l.Id == id && l.CreatedBy.UserName == name);
        }

        // GET: api/LeaderboardApi?id1=1&id2=2&id3=3
        public string Get(int id1, int id2, int id3)
        {
            return "works";
        }

        // POST: api/WebApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WebApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WebApi/5
        public void Delete(int id)
        {
        }
    }
}
