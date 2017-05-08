using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DecoreApp.Models;

namespace DecoreApp.ViewModels
{
    public class EventViewModel
    {

        public int Id { get; set; }
        public ICollection<Event> Events { get; set; }
        public int EventId { get; set; }


        [Required(ErrorMessage = "Title måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Adress { get; set; }


        [Required(ErrorMessage = "Beskrivning måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Description { get; set; }




    }
}