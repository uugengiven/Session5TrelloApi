using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session5TrelloApi.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class TrelloDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }
}