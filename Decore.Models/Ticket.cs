using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Decore.Models
{
    public class Ticket
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int NumberOfTickets { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public ICollection<Event> Events { get; set; }
    }
}