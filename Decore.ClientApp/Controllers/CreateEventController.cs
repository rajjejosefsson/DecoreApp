using System;
using System.Web.Mvc;
using Decore.ClientApp.EmployeeServiceReference;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;
//using log4net;

namespace Decore.ClientApp.Controllers
{
    public class CreateEventController : Controller
    {
        private readonly EmployeeServiceWCFClient _employeeWcfClient = new EmployeeServiceWCFClient();
        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();
       // private static readonly ILog logger = LogManager.GetLogger(typeof(CreateEventController));

        
        public ActionResult Index()
        {
       //     logger.Debug("Hello someone called create event");
            if(Session["userId"] != null || Session["employeeUserId"] != null)
            {
                var eventsTypes = _eventWCFclient.GetEventTypes();
                var sectionTypes = _employeeWcfClient.GetAllSections();
                var viewModel = new EventViewModel
                {
                    SectionTypes = sectionTypes,
                    EventTypes = eventsTypes
                };

                return View(viewModel);
            }

            return RedirectToAction("Index", "Home");
           

        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateEvent(EventViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.EventOwner = 1; // HARD CODED 
                viewModel.CreatedBy = 1; // HARD CODED


                var eventObject = new Event
                {
                    Id = viewModel.Id,
                    SectionId = viewModel.SectionId,
                    Title = viewModel.Title,
                    Description = viewModel.Description,
                    StartDate = viewModel.StartDate,
                    EndDate = viewModel.EndDate,
                    SaleStop = viewModel.SaleStop,
                    BasePrice = viewModel.BasePrice,
                    MemberPrice = viewModel.MemberPrice,
                    EventTypeId = viewModel.EventTypeId,
                    ZipCode = viewModel.ZipCode,
                    Adress = viewModel.Adress,
                    MaxEmployees = viewModel.MaxEmployees,
                    MaxTickets = viewModel.MaxTickets,
                    ImageURL = viewModel.ImageURL,
                    EventOwner = viewModel.EventOwner,
                    CreatedBy = viewModel.EventOwner,
                    CreatedAt = DateTime.Now,
                };
                _eventWCFclient.CreateEvent(eventObject);


                return RedirectToAction("Index", "EventList");
            }


            var eventsTypes = _eventWCFclient.GetEventTypes();
            viewModel.EventTypes = eventsTypes;


            return View("Index", viewModel);
        }


        public ActionResult UpdateEventById(int id)
        {
            var eventObj = _eventWCFclient.GetEventById(id);
            var eventsTypes = _eventWCFclient.GetEventTypes();
            var sectionTypes = _employeeWcfClient.GetAllSections();


            var viewModel = new EventViewModel
            {
                Id = eventObj.Id,
                SectionId = eventObj.SectionId,
                SectionTypes = sectionTypes,
                EventTypes = eventsTypes,
                Title = eventObj.Title,
                Description = eventObj.Description,
                StartDate = eventObj.StartDate,
                EndDate = eventObj.EndDate,
                SaleStop = eventObj.SaleStop,
                BasePrice = eventObj.BasePrice,
                MemberPrice = eventObj.MemberPrice,
                EventTypeId = eventObj.EventTypeId,
                MaxEmployees = eventObj.MaxEmployees,
                MaxTickets = eventObj.MaxTickets,
                ZipCode = eventObj.ZipCode,
                Adress = eventObj.Adress,
                ImageURL = eventObj.ImageURL,
                EventOwner = eventObj.EventOwner,
                CreatedBy = eventObj.EventOwner,
                UpdatedAt = DateTime.Now, // UPDATED NOW
                IsEdit = true
            };

            return View("Index", viewModel);
        }
    }
}