using Decore.Models;
using System.Collections.Generic;
using System.Linq;
using Decore.Data.UserServiceReference;

namespace Decore.Data.Repositories
{
   public class TicketRepository
    {
        private readonly UserServiceClient _UserWCFclient = new UserServiceClient();

       

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

    }
}
