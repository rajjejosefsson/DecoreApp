using System.Collections.Generic;
using Decore.Data.Repositories;
using Decore.Models;

namespace AlcoholService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlcoholService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlcoholService.svc or AlcoholService.svc.cs at the Solution Explorer and start debugging.
    public class AlcoholService : IAlcoholService
    {

        private readonly BeverageRepository _beverageRepository = new BeverageRepository();


        public void CreateBeverage(Beverage beverageObject)
        {
            _beverageRepository.CreateBeverage(beverageObject);
        }

        public ICollection<Beverage> GetBeverage()
        {
            var beverage = _beverageRepository.GetBeverages();

            return beverage;
        }


        public Beverage GetBeverageById(int beverageId)
        {
            return _beverageRepository.GetBeverageById(beverageId);
        }

    }
}
