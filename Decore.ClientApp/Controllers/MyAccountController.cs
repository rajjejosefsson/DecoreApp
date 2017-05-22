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
    public class MyAccountController : Controller
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


                var viewModel = new TicketViewModel
                {
                   Tickets = tickets,
                   Events = events
                };
                return View(viewModel);

            }

            return RedirectToAction("Index", "Home");


        }
    }
}