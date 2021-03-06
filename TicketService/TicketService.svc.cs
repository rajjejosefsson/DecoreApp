﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Decore.Data.Repositories;
using Decore.Models;

namespace TicketService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TicketService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TicketService.svc or TicketService.svc.cs at the Solution Explorer and start debugging.
    public class TicketService : ITicketService
    {

        private readonly TicketRepository _ticketRepository = new TicketRepository();

        public ICollection<Ticket> GetTickets()
        {
            return _ticketRepository.GetTickets();
        }

        public void CreateTicket(Ticket ticket)
        {
            _ticketRepository.CreateTicket(ticket);
        }

       public ICollection<Ticket> GetTicketByEventId(int eventId)
        {
            return _ticketRepository.GetTicketByEventId(eventId);
        }

    }
}
