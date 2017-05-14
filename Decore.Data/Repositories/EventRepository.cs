using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decore.Data.ScheduleServiceReference;

namespace Decore.Data.Repositories
{
    public class EventRepository
    {

        private readonly Service1Client _scheduleWCFclient = new Service1Client();


        public void CreateEvent(Models.Event eventObj)
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {

                if (eventObj.Id == 0)
                {
                    // Create
                    context.Events.Add(eventObj);
                    int id = eventObj.Id;

                    _scheduleWCFclient.AddEvent(id);

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

        public ICollection<Models.Event> GetEvents()
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


        public Models.Event GetEventById(int eventId)
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Events.AsNoTracking().SingleOrDefault(e => e.Id == eventId);
            }
        }

    }
}
