using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decore.Data.Repositories
{
   public class BeverageRepository
    {
        public ICollection<Beverage> GetBeverages()
        {
            using (DecoreDbContext context = new DecoreDbContext())
            {
                return context.Beverages.AsNoTracking().ToList();
            }
        }

        public void CreateBeverage(Beverage beverageObject)
        {
     
            using (var context = new DecoreDbContext())
            {
                if (beverageObject.Id == 0)
                {
                    // Create
                    context.Beverages.Add(beverageObject);
                }
                else
                {
                    // Edit
                    var beverageInDb = context.Beverages.SingleOrDefault(p => p.Id == beverageObject.Id);

                    beverageInDb.Id = beverageObject.Id;
                    beverageInDb.Name = beverageObject.Name;
                    beverageInDb.Amount = beverageObject.Amount;
                    beverageInDb.ImageURL = beverageObject.ImageURL;
                    beverageInDb.IsAlcoholic = beverageObject.IsAlcoholic;
                    beverageInDb.Percent = beverageObject.Percent;
                    beverageInDb.Price = beverageObject.Price;
                    beverageInDb.UnitOfMeasure = beverageObject.UnitOfMeasure;
                   


                }
                context.SaveChanges();
            }
        }

        public Beverage GetBeverageById(int beverageId)
        {
            using (var context = new DecoreDbContext())
            {
                return context.Beverages.AsNoTracking().SingleOrDefault(e => e.Id == beverageId);
            }
        }

        public void DeleteBeverageById(int beverageId)
        {
            using (var context = new DecoreDbContext())
            {
                // Get beverage by id
                var beverageInDb = context.Beverages.SingleOrDefault(e => e.Id == beverageId);
                context.Beverages.Remove(beverageInDb);
                context.SaveChanges();
            }
        }




        // ------NEW------

        public void PostBeverageCountUp(CountBeverage countBeverageItem)
        {
            using (var context = new DecoreDbContext())
            {
                context.CountBeverages.Add(countBeverageItem);
                context.SaveChanges();
            }
        }



        public ICollection<CountBeverage> GetBeverageCountUps()
        {
            using (var context = new DecoreDbContext())
            {
                return context.CountBeverages.AsNoTracking().ToList();
            }
        }


        public ICollection<CountBeverage> GetBeverageCountUpsByDateTime(DateTime countTime)
        {
            using (var context = new DecoreDbContext())
            {
                return context.CountBeverages.AsNoTracking().Where(t => t.CountTime == countTime).ToList();
            }
        }








    }
}
