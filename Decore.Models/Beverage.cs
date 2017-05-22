using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Decore.Models
{
    [DataContract]
    public class Beverage
    {
        [Required]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string Name { get; set; }

        [Required]
        [DataMember]
        public float Percent { get; set; }

        [Required]
        [DataMember]
        public float Price { get; set; }

        [Required]
        [DataMember]
        public bool IsAlcoholic { get; set; }

        [Required]
        [DataMember]
        public string ImageURL { get; set; }

        [Required]
        [DataMember]
        public float Amount { get; set; }

        [Required]
        [DataMember]
        public string UnitOfMeasure { get; set; }
    }
}