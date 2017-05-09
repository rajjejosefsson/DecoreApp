using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decore.data.Repositories
{
    public class EventRepository
    {


        public ICollection<Event> Events()
        {
            using (DecoreContext context = new DecoreContext())
            {
                return context.Events.AsNoTracking().ToList();
            }
        }


        public void CreateEvent(Event eventObject)
        {
            using (DecoreContext context = new DecoreContext())
            {
                context.Events.Add(eventObject);
                context.SaveChanges();
            }
        }


    }
}
