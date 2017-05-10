﻿using System;
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

    /// <summary>
    /// Class EventService.
    /// </summary>
    /// <seealso cref="EventService.IEventService" />
    public class EventService : IEventService
    {

        /// <summary>
        /// The event repository
        /// </summary>
        private readonly EventRepository _eventRepository = new EventRepository();


        /// <summary>
        /// Creates the event.
        /// </summary>
        /// <param name="eventObject">The event object.</param>
        public void CreateEvent(Event eventObject)
        {
            _eventRepository.CreateEvent(eventObject);
        }


        /// <summary>
        /// Gets the events.
        /// </summary>
        /// <returns>ICollection&lt;Event&gt;.</returns>
        public ICollection<Event> GetEvents()
        {
            var events = _eventRepository.GetEvents();
            return events;
        }


        /// <summary>
        /// Gets the event by identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns>Event.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Event GetEventById(int eventId)
        {
            throw new NotImplementedException();
        }




    }
}
