using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Decore.ClientApp.ViewModels
{
    public class AddTicketViewModel
    {

        public int TicketId { get; set; }

        public int EventId { get; set; }

        public int StudentId { get; set; }

        [Required(ErrorMessage = "Antal Biljetter måste anges")]
        public int NumberOfTickets { get; set; }



    }
}