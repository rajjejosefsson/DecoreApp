using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.TicketServiceReference;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly TicketServiceClient _ticketWcfClient = new TicketServiceClient();

        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();

        // GET: MyAccount
        public ActionResult Index()
        {


            if (Session["userId"] != null)
            {

                var alltickets = _ticketWcfClient.GetTickets();
                var events = _eventWCFclient.GetEvents();
                var tickets = new Dictionary<int, int>();
                foreach (var e in alltickets)
                {
                    if(tickets.ContainsKey(e.EventId))
                    {
                        tickets[e.EventId] += 1; 
                    }else
                    {
                        tickets.Add(e.EventId, 1);
                    }
                };

                var viewModel = new TicketViewModel
           
                {
                   Tickets = alltickets,
                   Events = events,
                   TicketsSold = tickets
                    
                };
                return View(viewModel);

            }

            return RedirectToAction("Index", "Home");


        }
    }
}