using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Decore.ClientApp.TicketServiceReference;

namespace Decore.ClientApp.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly TicketServiceClient _ticketWcfClient = new TicketServiceClient();
        // GET: MyAccount
        public ActionResult Index()
        {
           var tickets = _ticketWcfClient.GetTickets();
            return View();
        }
    }
}