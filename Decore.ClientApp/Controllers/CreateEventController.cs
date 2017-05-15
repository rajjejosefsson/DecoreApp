using System;
using System.Web.Mvc;
using Decore.ClientApp.EventServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{

    public class CreateEventController : Controller
    {

        private readonly EventServiceClient _eventWCFclient = new EventServiceClient();

        public ActionResult Index()
        {
            var eventsTypes = _eventWCFclient.GetEventTypes();
           
            var viewModel = new EventViewModel
            {
                EventTypes = eventsTypes
            };
            return View(viewModel);
        }


        



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateEvent(EventViewModel viewModel)
        {

            if(ModelState.IsValid)
            {


                viewModel.EventOwner = 1; // HARD CODED 
                viewModel.CreatedBy = 1; // HARD CODED


                var eventObject = new Event
                {
                    Id =  viewModel.Id,
                    Title = viewModel.Title,
                    Description = viewModel.Description,
                    StartDate = viewModel.StartDate,
                    EndDate = viewModel.EndDate,
                    SaleStop = viewModel.SaleStop,
                    BasePrice = viewModel.BasePrice,
                    MemberPrice = viewModel.MemberPrice,
                    EventTypeId = viewModel.EventTypeId,
                    ZipCode = viewModel.ZipCode,
                    Adress = viewModel.Adress,
                    ImageURL = viewModel.ImageURL,
                    EventOwner = viewModel.EventOwner,
                    CreatedBy = viewModel.EventOwner, 
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now // IS NOT NEEDED TO SHOW 
                };
                _eventWCFclient.CreateEvent(eventObject);
              


                return RedirectToAction("Index", "EventList");
            }

            

            var eventsTypes = _eventWCFclient.GetEventTypes();
            viewModel.EventTypes = eventsTypes;

            return View("Index", viewModel);
        }

       

        public ActionResult UpdateEventById(int id)
        {

            var eventObj = _eventWCFclient.GetEventById(id);
            var eventsTypes = _eventWCFclient.GetEventTypes();

            TempData["IsEdit"] = true;

            var viewModel = new EventViewModel
            {
                EventTypes = eventsTypes,
                Title = eventObj.Title,
                Description = eventObj.Description,
                StartDate = eventObj.StartDate,
                EndDate = eventObj.EndDate,
                SaleStop = eventObj.SaleStop,
                BasePrice = eventObj.BasePrice,
                EventTypeId = eventObj.EventTypeId,
                ZipCode = eventObj.ZipCode,
                Adress = eventObj.Adress,
                ImageURL = eventObj.ImageURL,
                EventOwner = eventObj.EventOwner,
                CreatedBy = eventObj.EventOwner,
                UpdatedAt = DateTime.Now, // UPDATED NOW
                IsEdit = true
            };

            return View("Index", viewModel);

        }




    }
}