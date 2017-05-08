using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecoreApp.ViewModels;
using DecoreApp.Models;


namespace DecoreApp.Controllers
{
    public class CreateEventController : Controller
    {
        public ActionResult Index()
        {
            var eventsTypes = new List<Event>
            {
                new Event() { Id = 1, EventType = "Sittning"},
                new Event() { Id = 2, EventType = "Mat hos patrik"},
                new Event() { Id = 3, EventType = "Fest"},
                new Event() { Id = 4, EventType = "Lan"},
            };
            var viewModel = new EventViewModel
            {
                Events = eventsTypes
            };
            return View(viewModel);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateEvent(EventViewModel viewModel)
        {


            // post to event webservice 


            // Send dummy data
            return RedirectToAction(
                "Index",
                "Events",
                new
                {
                    Title = viewModel.Title,
                    Description = viewModel.Description
                });
        }


    }
}