﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{

    public class CreateEventController : Controller
    {

        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();


        public ActionResult Index()
        {
            var eventsTypes = new Dictionary<int, string>
            {
               {0, "Sittning"},
               {1, "Fest"},
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


            var eventObject = new Event
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                StartDate = viewModel.StartDate,
                EndDate = viewModel.EndDate,
                SaleStop = viewModel.SaleStop,
                BasePrice = viewModel.BasePrice,
                EventType = viewModel.EventTypes, // ADD TO FORM
                ZipCode = viewModel.ZipCode,
                Adress = viewModel.Adress,
                ImageURL = viewModel.ImageURL,
                EventOwner = 1, // ADD TO FORM (NEED TO GET USER FIRST)
                CreatedBy = 1, // ADD TO FORM (NEED TO GET USER FIRST)
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now // IS NOT NEEDED TO SHOW 
            };
            _eventWCFclient.CreateEvent(eventObject);


            return RedirectToAction("Index", "EventList");
        }


    }
}