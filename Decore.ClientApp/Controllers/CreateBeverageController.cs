
using System.Web.Mvc;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class CreateBeverageController : Controller
    {
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
               

             
             


                return RedirectToAction("Index", "EventList");
            }
       
            


            return View("Index", viewModel);
        }
    }
}