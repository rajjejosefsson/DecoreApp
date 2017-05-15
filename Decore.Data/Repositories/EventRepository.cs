using Decore.Models;
using System.Collections.Generic;
using System.Linq;
using Event = Decore.Models.Event;


namespace Decore.Data.Repositories
{
    public class EventRepository
    {

        



        public void CreateEvent(Event eventObj)
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {

                if (eventObj.Id == 0)
                {
                    // Create
                    context.Events.Add(eventObj);
                   
                }
                else
                {
                    // Edit
                    var eventInDb = context.Events.SingleOrDefault(p => p.Id == eventObj.Id);

                    eventInDb.Title = eventObj.Title;
                    eventInDb.Description = eventObj.Description;
                    eventInDb.StartDate = eventObj.StartDate;
                    eventInDb.EndDate = eventObj.EndDate;
                    eventInDb.SaleStop = eventObj.SaleStop;
                    eventInDb.BasePrice = eventObj.BasePrice;
                    eventInDb.MemberPrice = eventObj.MemberPrice;
                    eventInDb.EventTypeId = eventObj.EventTypeId;
                    eventInDb.ZipCode = eventObj.ZipCode;
                    eventInDb.Adress = eventObj.Adress;
                    eventInDb.ImageURL = eventObj.ImageURL;
                    eventInDb.EventOwner = eventObj.EventOwner;
                    eventInDb.CreatedBy = eventObj.EventOwner;
                    eventInDb.CreatedAt = eventObj.CreatedAt;
                    eventInDb.UpdatedAt = eventObj.UpdatedAt;
                }
                context.SaveChanges();
               
            }
        }

        public ICollection<Event> GetEvents()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Events.AsNoTracking().ToList();
            }
        }

        public ICollection<EventType> GetEventTypes()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.EventTypes.AsNoTracking().ToList();
            }
        }

        public void DeleteEventById(int eventId)
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                // Get event by id
                var eventInDb = context.Events.SingleOrDefault(e => e.Id == eventId);
                context.Events.Remove(eventInDb);              
                context.SaveChanges();
            }
        }


        public Event GetEventById(int eventId)
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Events.AsNoTracking().SingleOrDefault(e => e.Id == eventId);
            }
        }

    }
}
