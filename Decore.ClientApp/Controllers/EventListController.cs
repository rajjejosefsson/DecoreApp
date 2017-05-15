using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.EmployeeServiceReference;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class EventListController : Controller
    {

      private readonly EventServiceClient _eventWCFclient = new EventServiceClient();
      private readonly EmployeeServiceWCFClient _employeeWcfClient = new EmployeeServiceWCFClient();


        public ActionResult Index()
        {
            var events = _eventWCFclient.GetEvents();
            var eventTypes = _eventWCFclient.GetEventTypes();
            var sectionTypes = _employeeWcfClient.GetAllSections();

            var viewModel = new EventViewModel
                {
                    Events = events,
                    EventTypes = eventTypes,
                    SectionTypes = sectionTypes
                };
                return View(viewModel);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEventById(int id)
        {
            _eventWCFclient.DeleteEventById(id);
            return RedirectToAction("Index", "EventList");
        }

       
    }


}
