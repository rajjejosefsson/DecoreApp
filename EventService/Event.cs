using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decore.models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SaleStop { get; set; }
        public float BasePrice { get; set; }
        public float MemberPrice { get; set; }
        public string EventType { get; set; }
        public string ZipCode { get; set; }
        public string Adress { get; set; }
        public string ImageURL { get; set; }
        public int EventOwner { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
