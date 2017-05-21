using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Decore.ClientApp.EventServiceReference;
using Decore.Models;

namespace Decore.ClientApp.Controllers.Api
{
    public class EventsController : ApiController
    {
        private readonly EventServiceClient _client = new EventServiceClient();


        // GET /api/events
        public IEnumerable<Event> GetEvents()
        {
            return _client.GetEvents();
        }


        // GET /api/events/id
        public Event GetEvent(int id)
        {
            var eventObj = _client.GetEventById(id);
            if (eventObj == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return eventObj;
        }
    }
}