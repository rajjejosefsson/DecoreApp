using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Decore.ClientApp.EmployeeServiceReference;
using Decore.Models;

namespace Decore.ClientApp.ViewModels
{
    public class EventViewModel
    {

        public TicketViewModel TicketViewModel { get; set; }






        public int Id { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<EventType> EventTypes { get; set; }
        public ICollection<SectionInfo> SectionTypes { get; set; }


        [Required(ErrorMessage = "Eventtyp måste anges")]
        public int EventTypeId { get; set; }


        [Required(ErrorMessage = "Title måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Adress { get; set; }


        [Required(ErrorMessage = "Image Url måste anges")]
        [StringLength(140, ErrorMessage = "Får ej vara över 140 bokstäver")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start datum måste anges")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Slut datum måste anges")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Säljeperiod måste anges")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime SaleStop { get; set; }


        [Required(ErrorMessage = "Event Owner måste anges")]
        public int EventOwner { get; set; }


        [Required(ErrorMessage = "Section Id needed")]
        public int SectionId { get; set; }


        [Required(ErrorMessage = "Event Owner måste anges")]
        public int CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Required(ErrorMessage = "Beskrivning måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Baspris måste anges")]
        public float BasePrice { get; set; }

        [Required(ErrorMessage = "Memberpris måste anges")]
        public float MemberPrice { get; set; }

        public bool IsEdit { get; set; }
    }
}