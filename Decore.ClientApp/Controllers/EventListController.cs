using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ScheduleServiceReference;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class EventListController : Controller
    {

      private readonly EventServiceClient _eventWCFclient = new EventServiceClient();
      private readonly Service1Client _scheduleWCFclient = new Service1Client();

        public ActionResult Index(string title, string description)
        {
            var events = _eventWCFclient.GetEvents();
            var eventTypes = _eventWCFclient.GetEventTypes();

            var viewModel = new EventViewModel
                {
                    Events = events,
                    EventTypes = eventTypes
                };
                return View(viewModel);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEventById(int id)
        {
            _eventWCFclient.DeleteEventById(id);
            _scheduleWCFclient.RemoveEvent(id);
            return RedirectToAction("Index", "EventList");
        }

       
    }


}
