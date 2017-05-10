using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Decore.Models;
using Decore.Data.Repositories;

namespace EventService
{



    public class EventService : IEventService
    {

        private readonly EventRepository _eventRepository = new EventRepository();


        public ICollection<Event> GetEvents()
        {
            var events = _eventRepository.GetEvents();
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
