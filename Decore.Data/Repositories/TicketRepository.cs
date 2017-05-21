using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Data.Repositories
{
    class TicketRepository
    {
        public ICollection<Ticket> GetTickets()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Tickets.AsNoTracking().ToList();
            }
        }
    }
}
