using System.Runtime.Serialization;

namespace Decore.Models
{
    [DataContract]
    public class EventType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}