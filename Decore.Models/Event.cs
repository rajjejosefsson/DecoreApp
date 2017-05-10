using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Models
{

    [DataContract(IsReference = true)]
    public class Event
    {

        [Required]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string Title { get; set; }

        [Required]
        [DataMember]
        public string Description { get; set; }

        [Required]
        [DataMember]
        public DateTime StartDate { get; set; }

        [Required]
        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public DateTime? SaleStop { get; set; }

        [DataMember]
        public float? BasePrice { get; set; }

        [Required]
        [DataMember]
        public string EventType { get; set; }

        [Required]
        [DataMember]
        public string ZipCode { get; set; }

        [Required]
        [DataMember]
        public string Adress { get; set; }

        [DataMember]
        public string ImageURL { get; set; }

        [Required]
        [DataMember]
        public int EventOwner { get; set; }

        [Required]
        [DataMember]
        public int CreatedBy { get; set; }

        [Required]
        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public DateTime? UpdatedAt { get; set; }


    }
}
