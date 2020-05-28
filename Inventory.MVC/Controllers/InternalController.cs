using Inventory.MODELS.InternalStorageModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class InternalController : Controller
    {
        // GET: Internal
        public ActionResult Index()
        {
            var service = new InternalService();
            var exList = service.GetAllInternals();
            return View(exList);
        }

        // GET: Internal/Details/5
        public ActionResult Details(int id)
        {
            var service = new InternalService();
            var model = service.GetInternalById(id);
            return View(model);
        }

        // GET: Internal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Internal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InternalCreate ex)
        {
            var service = new InternalService();
            if (ModelState.IsValid)
            {
                service.CreateInternal(ex);
                return RedirectToAction("Index");
            }
            return View(ex);
        }

        // GET: Internal/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new InternalService();
            var detail = service.GetInternalById(id);
            var model = new InternalEdit
            {
                Id = detail.Id,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Capacity = detail.Capacity,
                Interface = detail.Interface,
                Type = detail.Type,
                FormFactor = detail.FormFactor,
                NVME = detail.NVME,
                IsAvailable = detail.IsAvailable
            };
            return View(model);
        }

        // POST: Internal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, InternalEdit model)
        {
            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new InternalService();

            if (service.UpdateInternal(model))
            {
                TempData["SaveResult"] = "Your Internal drive information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Internal drive information could not be updated.");
            return View();
        }

        // GET: Internal/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new InternalService();
            var model = service.GetInternalById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Internal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteInternal(int id)
        {
            var service = new InternalService();

            service.DeleteInternal(id);

            TempData["SaveResult"] = "Your Internal drive entry was deleted.";
            return RedirectToAction("Index");
        }
    }
}
