﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Decore.Models
{

    [DataContract]
    public class Ticket
    {
        [Required]
        [DataMember]
        public int Id { get; set; }


        [Required]
        [DataMember]
        public DateTime BoughtAt { get; set; }

        [Required]
        [DataMember]
        public int AmountOfTickets { get; set; }

        [Required]
        [DataMember]
        public int UserId { get; set; }

        [Required]
        [DataMember]
        public int EventId { get; set; }
    }
}