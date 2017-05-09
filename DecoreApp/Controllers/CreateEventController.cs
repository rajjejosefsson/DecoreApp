using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecoreApp.ViewModels;
using DecoreApp.EventServiceReference;

namespace DecoreApp.Controllers
{

    public class CreateEventController : Controller
    {

        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();


        public ActionResult Index()
        {
            var eventsTypes = new Dictionary<int, string>
            {
               {0, "Sittning"},
               {1, "Leka"},
               {2, "Dansa"},
            };

            var viewModel = new EventViewModel
            {
                EventTypes = eventsTypes
            };
            return View(viewModel);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateEvent(EventViewModel viewModel)
        {


            // post to event webservice 

            var eventObj = new Event();
            var ev = new Event {Title = "Patrik Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går" };

            _eventWCFclient.CreateEvent(ev);
            
            
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