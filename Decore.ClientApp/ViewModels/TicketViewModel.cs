using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Decore.ClientApp.EventServiceReference;
using Decore.Models;


namespace Decore.ClientApp.ViewModels
{
    public class TicketViewModel

    {
        public int TicketId { get; set; }

        public int EventId { get; set; }

        public int StudentId { get; set; }

        public DateTime BoughtAt { get; set; }

        [Required(ErrorMessage = "Antal Biljetter måste anges")]
        public int AmountOfTickets { get; set; }  
    

        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Event> Events { get; set; }

    }
}