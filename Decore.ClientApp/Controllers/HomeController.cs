using System.Web.Mvc;
using Decore.ClientApp.LoginServiceReference;
using Decore.ClientApp.ViewModels;
//using log4net;

namespace Decore.ClientApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginServiceClient _LoginWCFclient = new LoginServiceClient();
    //    private static readonly ILog logger = LogManager.GetLogger(typeof(CreateEventController));


        public ActionResult Index()
        {
          //  logger.Debug("Hello someone called tried to login");
            var viewModel = new LoginViewModel
            {
                Username = "",
                Password = ""
            };
            if (Session["userId"] != null)
            {
                return RedirectToAction("Index", "EventList");
            }
            else
            {
                return View(viewModel);
            }
            
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
          
         
        
            var employeeUser = _LoginWCFclient.LoginEmployee(viewModel.Username, viewModel.Password);


            // Load login
          //  logger.Debug("Hello someone called loginEmployee");
            if (employeeUser != null) {  
          //      logger.Debug("Loggin worked");

                Session["userId"] = employeeUser.Id;
                var userId = Session["userId"];
               
                return RedirectToAction("Index", "EventList");

            }

            else {
             //   logger.Debug("Loggin failed");
                ModelState.AddModelError("", "Username or Password is wrong");
                return RedirectToAction("Index", "Home");
            }

            

            // Fungerar inte
            // 
        }
        public ActionResult Logout()
        {
            Session["userId"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}