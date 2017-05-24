using System.Web.Mvc;
using Decore.ClientApp.LoginServiceReference;
using Decore.ClientApp.ViewModels;

namespace Decore.ClientApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginServiceClient _LoginWCFclient = new LoginServiceClient();


        public ActionResult Index()
        {

            var viewModel = new LoginViewModel
            {
                Username = "",
                Password = ""
            };

            return View(viewModel);
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


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult LoginEmployee(LoginViewModel viewModel)
        {
            // fungerar
            var studentUser = _LoginWCFclient.LoginStudent(viewModel.Username, viewModel.Password);

            // Load login

            if (studentUser.StudentId != null) {

                Session["userId"] = studentUser.Id;
                var userId = Session["userId"];
               
                return RedirectToAction("Index", "EventList");
            }

            else {
                ModelState.AddModelError("", "Username or Password is wrong");
                return RedirectToAction("Index", "Home");
            }

            

            // Fungerar inte
            // var employeeUser = _LoginWCFclient.LoginEmployee(viewModel.Username, viewModel.Password);
        }
    }
}