using System.Web.Mvc;
using Decore.ClientApp.AlcoholServiceReference;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class BeverageListController : Controller
    {
        private readonly AlcoholServiceClient _beverageWcfClient = new AlcoholServiceClient();

        public ActionResult Index()
        {
            var beverages = _beverageWcfClient.GetBeverage();

            if (Session["userId"] != null || Session["employeeUserId"] != null)
            {
                var viewModel = new BeverageViewModel
                {
                    Beverages = beverages
                };
                return View(viewModel);
            }
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBeverageById(int id)
        {
            _beverageWcfClient.DeleteBeverageById(id);
            return RedirectToAction("Index", "BeverageList");
        }

    }
}