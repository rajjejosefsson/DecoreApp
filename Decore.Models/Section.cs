using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Models
{
    [DataContract]
    public class Section
    {
        [Required]
        [DataMember]
        public int Id { get; set; }


        [Required]
        [DataMember]
        public int SectionId { get; set; }


        [Required]
        [DataMember]
        public int EventId { get; set; }



        [DataMember]
        public ICollection<Event> Events { get; set; }


        public Section()
        {
               Events = new Collection<Event>();
        }

    }
}
// 1  4
// 1  3
// 5  3
// 2  6