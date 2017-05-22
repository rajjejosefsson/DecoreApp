using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TicketService
{
    [ServiceContract]
    public interface ITicketService
    {

        [OperationContract]
        ICollection<Ticket> GetTickets();
     
        [OperationContract]
        void CreateTicket(Ticket ticket);
       
    //    [OperationContract]
     //   Ticket GetTicketByUserId(int userId);

    }
}
