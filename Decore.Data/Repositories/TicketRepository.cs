using Decore.Models;
using System.Collections.Generic;
using System.Linq;

namespace Decore.Data.Repositories
{
   public class TicketRepository
    {

       

        public void CreateTicket(Ticket ticket)
        {
            using (var context = new DecoreDbContext())
            {
                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
        }


        public ICollection<Ticket> GetTickets()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Tickets.AsNoTracking().ToList();
            }
        }

        
        public ICollection<Ticket> GetTicketsByUserId(int userId)
        {
          
          using (var context = new DecoreDbContext())      
          {
                    return context.Tickets.AsNoTracking().Where(t => t.UserId == userId).ToList();
          }
       }


        public ICollection<Ticket> GetTicketByEventId(int eventId)
        {
            using (var context = new DecoreDbContext())
            {
                return context.Tickets.AsNoTracking().Where(t => t.EventId == eventId).ToList();
            }
        }

    }
}
