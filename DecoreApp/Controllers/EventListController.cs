using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecoreApp.ViewModels;
using DecoreApp.EventServiceReference;

namespace DecoreApp.Controllers
{
    public class EventListController : Controller
    {

      private readonly EventServiceClient _eventWCFclient = new EventServiceClient();


        public ActionResult Index(string title, string description)
        {


            // TODO: skiter sig 
           var events = _eventWCFclient.GetEvents();


        var viewModel = new EventViewModel
            {
                Events = events
            };

            return View(viewModel);
        }
    }
}