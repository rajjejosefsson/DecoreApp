using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.TicketServiceReference;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;

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

                var tickets = _ticketWcfClient.GetTickets();
                var events = _eventWCFclient.GetEvents();




                    
              


                var alltickets = new Dictionary<int, int>();
                foreach (var e in tickets)
                {
                    if(alltickets.ContainsKey(e.EventId))
                    {
                        alltickets[e.EventId] += 1; 
                    }else
                    {
                        alltickets.Add(e.EventId, 1);
                        
                    }
                };

                var viewModel = new TicketViewModel
           
                {
                   Tickets = tickets,
                   Events = events,
                   TicketsSold = alltickets
                   
                    
                };
                return View(viewModel);

            }

            return RedirectToAction("Index", "Home");


        }
    }
}