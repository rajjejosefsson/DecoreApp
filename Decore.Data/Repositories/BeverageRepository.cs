using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Data.Repositories
{
    class BeverageRepository
    {
        public ICollection<Beverage> GetBeverages()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Beverages.AsNoTracking().ToList();
            }
        }


    }
}
