using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DecoreApp.ViewModels;
using DecoreApp.Models;


namespace DecoreApp.Controllers
{
    public class EventListController : Controller
    {

        public ActionResult Index(string title, string description)
        {

            var events = new List<Event>
            {
                new Event() { Id = 1, Title = "Patrik Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { Id = 2, Title = "Vidar visar upp sig", EventType = "Sittning", Adress = "Hos Vidar 21", Description = "Se Vidar gå loss"},
                new Event() { Id = 3, Title = "Vidar går och handlar", EventType = "Shopping", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { Id = 4, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
            };

        var viewModel = new EventViewModel
            {
                Events = events
            };

            return View(viewModel);
        }
    }
}