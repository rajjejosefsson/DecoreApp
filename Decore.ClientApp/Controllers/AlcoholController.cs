using System;
using System.Collections.Generic;
using System.Linq;
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

            if (Session["userId"] != null || Session["employeeUserId"] != null)
            {
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
            else { 
          
                return RedirectToAction("Index", "Home");
            }
        }


        public ActionResult Counting()
        {

            if (Session["userId"] != null || Session["employeeUserId"] != null)
            {
                var countings = _beverageWcfClient.GetBeverageCountUps();
                var beverages = _beverageWcfClient.GetBeverage();
                var countTimes = _beverageWcfClient.GetCountDateTimes();


                var viewModel = new CountBeverageViewModel
                {
                    CountBeverages = countings,
                    Beverages = beverages,
                    CountDateTimes = countTimes
                };


                return View(viewModel);
            }
            else {
          return RedirectToAction("Index", "Home");
            }
        }


        public ActionResult CountDown(DateTime dateTime)
        {

            if (Session["userId"] != null || Session["employeeUserId"] != null)
            {
                var countings = _beverageWcfClient.GetBeverageCountUpsByDateTime(dateTime);

                // temp
                var countings2 = _beverageWcfClient.GetBeverageCountUps();
                var testCountings = countings2.Where(d => d.CountTime.ToString() == dateTime.ToString()).ToList();


                var beverages = _beverageWcfClient.GetBeverage();


                var viewModel = new CountBeverageViewModel
                {
                    CountBeverages = testCountings,
                    Beverages = beverages,
                };


                return View(viewModel);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }




        [HttpPost]
        public ActionResult PostCountBeverage (List<CountBeverage> results)
        {
            var countTime = DateTime.Now;

            foreach (var countResult in results)
            {
                var countItem = new CountBeverage()
                {
                    CountTime = countTime, 
                    BeverageId = countResult.BeverageId,
                    Amount = countResult.Amount,
                };
                 _beverageWcfClient.PostBeverageCountUp(countItem);
            }

            _beverageWcfClient.PostCountDateTime(countTime);


            return RedirectToAction("Counting", "Alcohol");

        }
    }
}