using Decore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AlcoholService
{

    [ServiceContract]
    public interface IAlcoholService
    {

        [OperationContract]
        ICollection<Beverage> GetBeverages();
        
         
    }
}

