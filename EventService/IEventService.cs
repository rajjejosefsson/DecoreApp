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
    [ServiceContract]
    public interface IEventService
    {
        [OperationContract]
        ICollection<Event> GetEvents();

        [OperationContract]
        Event GetEventById(int eventId);

        [OperationContract]
        void CreateEvent(Event eventObject);

    }
}
