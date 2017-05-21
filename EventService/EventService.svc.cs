using System.Collections.Generic;
using Decore.Data.Repositories;
using Decore.Models;

namespace EventService
{
    /// <summary>
    ///     s
    ///     Class EventService.
    /// </summary>
    /// <seealso cref="IEventService" />
    public class EventService : IEventService
    {
        /// <summary>
        ///     The event repository
        /// </summary>
        private readonly EventRepository _eventRepository = new EventRepository();


        /// <summary>
        ///     Creates the event.
        /// </summary>
        /// <param name="eventObject">The event object.</param>
        public void CreateEvent(Event eventObject)
        {
            _eventRepository.CreateEvent(eventObject);
        }


        /// <summary>
        ///     Gets the events.
        /// </summary>
        /// <returns>ICollection&lt;Event&gt;.</returns>
        public ICollection<Event> GetEvents()
        {
            var events = _eventRepository.GetEvents();

            return events;
        }


        /// <summary>
        ///     Gets the event by identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns>Event.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Event GetEventById(int eventId)
        {
            return _eventRepository.GetEventById(eventId);
        }

        public ICollection<Event> GetEventsBySectionId(int sectionId)
        {
            return _eventRepository.GetEventsBySectionId(sectionId);
        }


        public ICollection<EventType> GetEventTypes()
        {
            return _eventRepository.GetEventTypes();
        }

        public void DeleteEventById(int eventId)
        {
            _eventRepository.DeleteEventById(eventId);
        }
    }
}