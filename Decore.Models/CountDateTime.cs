using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Models
{
    [DataContract]
    public class CountDateTime
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public DateTime CountTime { get; set; }
    }
}
