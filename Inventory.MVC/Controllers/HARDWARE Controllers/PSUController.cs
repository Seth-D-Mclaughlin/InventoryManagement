using Inventory.DATA;
using Inventory.MODELS.PSUModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers.HARDWARE_Controllers
{
    public class PSUController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: PSU
        public ActionResult Index()
        {
            var service = new PSUService();
            var psuList = service.GetAllPowerSupplyUnits();
            return View(psuList);
        }

        // GET: PSU/Details/5
        public ActionResult Details(int id)
        {
            var service = new PSUService();
            var model = service.GetPSUById(id);
            return View(model);
        }

        // GET: PSU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PSU/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PSUCreate psu)
        {
            var service = new PSUService();
            if (ModelState.IsValid)
            {
                service.CreatePSU(psu);
                return RedirectToAction("Index");
            }
            return View(psu);

        }

        // GET: PSU/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new PSUService();
            var detail = service.GetPSUById(id);
            var model = new PSUEdit
            {
                Id = detail.Id,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Type = detail.Type,
                EffeciencyRating = detail.EffeciencyRating,
                TypeOfModular = detail.TypeOfModular,
                Color = detail.Color,
                Fanless = detail.Fanless,
                ATXConnectors = detail.ATXConnectors,
                IsAvailable = detail.IsAvailable
            };
            return View(model);
        }

        // POST: PSU/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PSUEdit model)
        {
            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = new PSUService();
            if (service.UpdatePSU(model))
            {
                TempData["SaveResult"] = "Your PSU information was updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your PSU information could not be updated.");
            return View();
        }

        // GET: PSU/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new PSUService();
            var model = service.GetPSUById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: PSU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePSU(int id)
        {
            var service = new PSUService();
            service.DeletePSU(id);

            TempData["SaveResult"] = "Your PSU entry was deleted.";

            return RedirectToAction("Index");
        }
    }
}

