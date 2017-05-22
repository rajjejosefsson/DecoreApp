using System.Web.Mvc;
using Decore.ClientApp.EmployeeServiceReference;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.TicketServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{
    public class EventListController : Controller
    {
        private readonly EmployeeServiceWCFClient _employeeWcfClient = new EmployeeServiceWCFClient();

        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();

        private readonly TicketServiceClient _ticketWCFclient = new TicketServiceClient();


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


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateTicket(EventViewModel viewModel)
        {

            
                viewModel.TicketViewModel.StudentId = 1; 

       

                var ticket = new Ticket
                {
                    Id = viewModel.TicketViewModel.TicketId,
                    EventId = viewModel.TicketViewModel.EventId,
                    UserId = viewModel.TicketViewModel.StudentId,
                    NumberOfTickets = viewModel.TicketViewModel.NumberOfTickets,
                   
                };
                _ticketWCFclient.CreateTicket(ticket);


                return RedirectToAction("Index", "EventList");
     

          
        }
    }
}