using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Data.Repositories
{
    public class EventRepository
    {


        public void CreateEvent(Event eventObject)
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                context.Events.Add(eventObject);
                context.SaveChanges();
            }
        }

        public ICollection<Event> GetEvents()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Events.Include("EventType").AsNoTracking().ToList();
            }
        }

        public ICollection<EventType> GetEventTypes()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.EventTypes.AsNoTracking().ToList();
            }
        }

    }
}
