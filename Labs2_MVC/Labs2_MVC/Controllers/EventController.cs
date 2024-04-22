using Labs2_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labs2_MVC.Controllers
{
    public class EventController : Controller
    {
        private static List<EventModel> events = new List<EventModel>();
        // GET: Event
        public ActionResult Index()
        {
            return View(events);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EventModel model)
        {
            if(ModelState.IsValid)
            {
                model.Id = events.Any() ? events.Max(e => e.Id) + 1 : 1;
                events.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id) 
        {
            var model = events.Find(e => e.Id == id);
            if(model == null)
            {
                return HttpNotFound();
            }
            
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(EventModel model)
        {
            if(ModelState.IsValid)
            {
                var currentEvent = events.Find(e =>e.Id == model.Id);
                if(currentEvent != null) 
                {
                    currentEvent.Name = model.Name;
                    currentEvent.Location = model.Location;
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        
        public ActionResult Delete(int id)
        {
            foreach(EventModel model in events.ToList())
            {
                if(model.Id == id)
                {
                    events.Remove(model);
                }
            }
            return RedirectToAction("Index", "Event");
        }

    }
}