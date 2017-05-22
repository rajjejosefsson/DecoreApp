﻿using System.Web.Mvc;
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


            var viewModel = new BeverageViewModel
            {
                Beverages = beverages
            };
            return View(viewModel);
        }

       
    }
}