using System.Collections.Generic;
using System.Web.Mvc;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{
    public class AlcoholController : Controller
    {
        // GET: Alcohol

        public ActionResult Index()
        {

           


                if (Session["userId"] != null)
                {
                var beverages = new List<Beverage>
                {

                };


                var measures = new List<Measure>
            {
                new Measure {MeasureId = 1, MeasureType = "Styck"},
                new Measure {MeasureId = 2, MeasureType = "Gram"},
                new Measure {MeasureId = 3, MeasureType = "Centiliter"},
                new Measure {MeasureId = 4, MeasureType = "Liter"}
            };

                var viewModel = new BeverageViewModel
                {
                    Beverages = beverages,
                    Beverage = new Beverage(),
                    Measures = measures
                };

                return View(viewModel);


                }

                return RedirectToAction("Index", "Home");


        }
    }
}