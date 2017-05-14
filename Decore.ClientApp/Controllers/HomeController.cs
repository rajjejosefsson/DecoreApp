using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Decore.ClientApp.LoginServiceReference;

namespace Decore.ClientApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly LoginServiceClient _LoginWCFclient = new LoginServiceClient();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        protected void LoginEmployee(string Email, string Password)
        {
            
            try
            {
                _LoginWCFclient.LoginEmployee(Email, Password);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); //Login Error...
            }
           
        }

        protected void LoginStudent(string Email, string Password)
        {

            try
            {
                _LoginWCFclient.LoginStudent(Email, Password);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); //Login Error...
            }

        }

    }
}