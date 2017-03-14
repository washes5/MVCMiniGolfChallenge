using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMiniGolfChallenge.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerLastName { get; set; }
        public string PlayerFirstName { get; set; }
        public int PlayerScore { get; set; }
    }

    public class PlayerDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}