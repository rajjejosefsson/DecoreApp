using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Decore.ClientApp.AlcoholServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{
    public class AlcoholController : Controller
    {
        private readonly AlcoholServiceClient _beverageWcfClient = new AlcoholServiceClient();

        public ActionResult Index()
        {

            if (Session["userId"] == null || Session["employeeUserId"] == null)
                return RedirectToAction("Index", "Home");


            var measures = new List<Measure>
            {
                new Measure {MeasureId = 1, MeasureType = "Styck"},
                new Measure {MeasureId = 2, MeasureType = "Gram"},
                new Measure {MeasureId = 3, MeasureType = "Centiliter"},
                new Measure {MeasureId = 4, MeasureType = "Liter"}
            };

            var viewModel = new BeverageViewModel
            {
                Beverages = _beverageWcfClient.GetBeverage(),
                Measures = measures
            };

            return View(viewModel);
        }

        public ActionResult Counting()
        {

            if (Session["userId"] == null)
                return RedirectToAction("Index", "Home");


           var countings = _beverageWcfClient.GetBeverageCountUps();
            var beverages = _beverageWcfClient.GetBeverage();


            var viewModel = new CountBeverageViewModel
            {
                CountBeverages = countings,
                Beverages = beverages
            };


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult PostCountBeverage (List<CountBeverage> results)
        {
            var countTime = DateTime.Now;

            foreach (var countResult in results)
            {
                // create object to send to db with the global countTime above
                var countItem = new CountBeverage()
                {
                    CountTime = countTime, 
                    BeverageId = countResult.BeverageId,
                    Amount = countResult.Amount,
                };

                // Db will look like this:
                // Id, DateTime, BeverageId, Amount
                // Id, DateTime, BeverageId, Amount
                // Id, DateTime, BeverageId, Amount

                 _beverageWcfClient.PostBeverageCountUp(countItem);
            }

            _beverageWcfClient.PostCountDateTime(countTime);


            return RedirectToAction("Counting", "Alcohol");

        }
    }
}