using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Decore.ClientApp.ViewModels
{
    public class CreateBeverageViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alco NAMN TACK")]
        public string Name { get; set; }

        public float Percent { get; set; }

        public float Price { get; set; }

        public bool IsAlcoholic { get; set; }

        public string ImageURL { get; set; }

        public float Amount { get; set; }

        public string UnitOfMeasure { get; set; }
    }
}