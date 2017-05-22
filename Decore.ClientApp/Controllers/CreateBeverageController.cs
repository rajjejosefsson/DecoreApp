using Decore.ClientApp.AlcoholServiceReference;
using System.Web.Mvc;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{
    public class CreateBeverageController : Controller
    {

        private readonly AlcoholServiceClient _beverageWcfClient = new AlcoholServiceClient();


        public ActionResult Index()
        {
            var viewModel = new CreateBeverageViewModel
            {
               
            };
            return View(viewModel);
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateBeverage(CreateBeverageViewModel viewModel)
        {
           

            if (ModelState.IsValid)
            {

                var beverageObject = new Beverage
                {
                    Id = viewModel.Id,
                    Name = viewModel.Name,
                    Amount = viewModel.Amount,
                    Percent = viewModel.Percent,
                    Price = viewModel.Price,
                    IsAlcoholic = viewModel.IsAlcoholic,
                    ImageURL = viewModel.ImageURL,
                    UnitOfMeasure = viewModel.UnitOfMeasure

                };
              
                return RedirectToAction("Index", "EventList");
            }
       
            


            return View("Index", viewModel);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult UpdateBeverageById(int id)
        {
            var beverageObj = _beverageWcfClient.GetBeverageById(id);
           
            var viewModel = new CreateBeverageViewModel
            {
                Id = beverageObj.Id,
                Name = beverageObj.Name,
                Amount = beverageObj.Amount,
                ImageURL = beverageObj.ImageURL,
                IsAlcoholic = beverageObj.IsAlcoholic,
                Percent = beverageObj.Percent,
                Price = beverageObj.Price,
                UnitOfMeasure = beverageObj.UnitOfMeasure,          
                IsEdit = true
            };

            return View("Index", viewModel);
        }
    }
}