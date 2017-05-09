using System.Collections.Generic;
using DecoreApp.Models;

namespace DecoreApp.ViewModels
{
    public class BeverageViewModel
    {
        public ICollection<Beverage> Beverages { get; set; }
        public Beverage Beverage { get; set; }
        public ICollection<Measure> Measures { get; set; }
    }
}