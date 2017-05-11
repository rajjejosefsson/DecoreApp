using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class EventListController : Controller
    {

      private readonly EventServiceClient _eventWCFclient = new EventServiceClient();


        public ActionResult Index(string title, string description)
        {
            var events = _eventWCFclient.GetEvents();
            var viewModel = new EventViewModel
                {
                    Events = events
                };
                return View(viewModel);
            }
    }
}