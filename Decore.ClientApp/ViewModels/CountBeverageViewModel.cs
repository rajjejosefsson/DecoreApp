using System.Collections.Generic;
using Decore.Models;

namespace Decore.ClientApp.ViewModels
{
    public class CountBeverageViewModel
    {
        public ICollection<CountBeverage> CountBeverages { get; set; }
        public ICollection<Beverage> Beverages { get; set; }
        public ICollection<CountDateTime> CountDateTimes { get; set; }


    }
}