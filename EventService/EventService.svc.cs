using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Decore.Models;
using decore.data.Repositories;


namespace EventService
{
    public class EventService : IEventService
    {

        private readonly EventRepository _eventRepository = new EventRepository();

        public ICollection<Event> GetEvents()
        {
            var events = new List<Event>
            {
                new Event() { Id = 1, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { Id = 2, Title = "Vidar visar upp sig", EventType = "Sittning", Adress = "Hos Vidar 21", Description = "Se Vidar gå loss"},
                new Event() { Id = 3, Title = "Vidar går och handlar", EventType = "Shopping", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { Id = 4, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
            };

            return events;
        }

        public Event GetEventById(int eventId)
        {
            throw new NotImplementedException();
        }

        public void CreateEvent(Event eventObject)
        {
            _eventRepository.CreateEvent(eventObject);
        }
    }
}
