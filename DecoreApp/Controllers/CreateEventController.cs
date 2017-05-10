using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecoreApp.ViewModels;
using DecoreApp.EventServiceReference;
using Decore.Models;

namespace DecoreApp.Controllers
{

    public class CreateEventController : Controller
    {

        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();


        public ActionResult Index()
        {
            var eventsTypes = new Dictionary<int, string>
            {
               {0, "Sittning!"},
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


            var ev = new Event
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                SaleStop = DateTime.Now,
                BasePrice = 23,
                EventType = "Sittning",
                ZipCode = viewModel.ZipCode,
                Adress = viewModel.Adress,
                ImageURL = viewModel.ImageURL,
                EventOwner = 1,
                CreatedBy = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _eventWCFclient.CreateEvent(ev);


            return RedirectToAction("Index", "Events");
        }


    }
}