using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace Decore.Models
{
    [DataContract]
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
        public int EventTypeId { get; set; }

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
