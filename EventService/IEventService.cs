// ***********************************************************************
// Assembly         : EventService
// Author           : rasmusjosefsson
// Created          : 05-10-2017
//
// Last Modified By : rasmusjosefsson
// Last Modified On : 05-10-2017
// ***********************************************************************
// <copyright file="IEventService.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Decore.Models;

namespace EventService
{
    /// <summary>
    /// Interface IEventService
    /// </summary>
    [ServiceContract]
    public interface IEventService
    {
        /// <summary>
        /// Gets the events.
        /// </summary>
        /// <returns>ICollection&lt;Event&gt;.</returns>
        [OperationContract]
        ICollection<Event> GetEvents();

        /// <summary>
        /// Gets the event by identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns>Event.</returns>
        [OperationContract]
        Event GetEventById(int eventId);

        /// <summary>
        /// Creates the event.
        /// </summary>
        /// <param name="eventObject">The event object.</param>
        [OperationContract]
        void CreateEvent(Event eventObject);

    }
}
