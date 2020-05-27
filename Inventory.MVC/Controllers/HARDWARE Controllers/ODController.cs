using Inventory.DATA;
using Inventory.MODELS.OpticalDriveModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Inventory.MVC.Controllers
{
    public class ODController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: OD
        public ActionResult Index()
        {
            var service = new ODService();
            var odList = service.GetAllODs();
            return View(odList);
        }

        // GET: OD/Details/5
        public ActionResult Details(int id)
        {
            var service = new ODService();
            var model = service.GetODById(id);
            return View(model);
        }

        // GET: OD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OD/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ODCreate od)
        {
            var service = new ODService();
            if (ModelState.IsValid)
            {
                service.CreateOD(od);
                return RedirectToAction("Index");
            }
            return View(od);
        }

        // GET: OD/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new ODService();
            var detail = service.GetODById(id);
            var model = new ODEdit
            {
                Id = detail.Id,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                FormFactor = detail.FormFactor,
                Interface = detail.Interface,
                Capability = detail.Capability,
                Color = detail.Color,
                BufferCache = detail.BufferCache,
                IsAvailable = detail.IsAvailable
            };
            return View(model);
        }

        // POST: OD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ODEdit model)
        {
            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = new ODService();
            if (service.UpdateOD(model))
            {
                TempData["SaveResult"] = "Your Optical Drive information was updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your Optical Drive information could not be updated.");
            return View();
        }

        // GET: OD/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new ODService();
            var model = service.GetODById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: OD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteOD(int id)
        {
            var service = new ODService();
            service.DeleteOD(id);
            TempData["SaveResult"] = "Your Optical drive entry was deleted.";

            return RedirectToAction("Index");
        }
    }
}
