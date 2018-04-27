using Session5TrelloApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session5TrelloApi.Controllers
{
    public class CardsController : Controller
    {
        // GET: Cards
        public JsonResult Index()
        {
            TrelloDbContext db = new TrelloDbContext();
            var reader = db.Cards.ToList();

            return new JsonResult() { Data = reader, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // GET: Cards/new
        public JsonResult New(string Title)
        {
            TrelloDbContext db = new TrelloDbContext();
            Card card = new Card();
            card.Title = Title;
            db.Cards.Add(card);
            db.SaveChanges();

            return new JsonResult() { Data = card, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}