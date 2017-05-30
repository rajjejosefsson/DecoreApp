using System;
using System.Collections.Generic;
using System.ServiceModel;
using Decore.Models;

namespace AlcoholService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlcoholService" in both code and config file together.
    [ServiceContract]
    public interface IAlcoholService
    {
        [OperationContract]
        ICollection<Beverage> GetBeverage();

        [OperationContract]
        Beverage GetBeverageById(int beverageId);

        [OperationContract]
        void CreateBeverage(Beverage beverageObject);

        [OperationContract]
        void DeleteBeverageById(int beverageId);


        [OperationContract]
        ICollection<CountBeverage> GetBeverageCountUps();

        [OperationContract]
        ICollection<CountBeverage> GetBeverageCountUpsByDateTime(DateTime countTime);

        [OperationContract]
        void PostBeverageCountUp(CountBeverage countBeverageItem);

        [OperationContract]
        void PostCountDateTime(DateTime countTime);



    }
}
