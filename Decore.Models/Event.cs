using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Models
{

    [DataContract(IsReference = true)]
    public class Event
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public DateTime SaleStop { get; set; }

        [DataMember]
        public float BasePrice { get; set; }

        [DataMember]
        public string EventType { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string Adress { get; set; }

        [DataMember]
        public string ImageURL { get; set; }

        [DataMember]
        public int EventOwner { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public DateTime UpdatedAt { get; set; }


    }
}
