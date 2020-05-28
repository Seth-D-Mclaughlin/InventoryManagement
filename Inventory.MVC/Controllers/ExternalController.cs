using Inventory.MODELS.ExternalStorageModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class ExternalController : Controller
    {
        // GET: External
        public ActionResult Index()
        {
            var service = new ExternalService();
            var exList = service.GetAllExternals();
            return View(exList);
        }

        // GET: External/Details/5
        public ActionResult Details(int id)
        {
            var service = new ExternalService();
            var model = service.GetExternalById(id);
            return View(model);
        }

        // GET: External/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: External/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExternalCreate ex)
        {
            var service = new ExternalService();
            if (ModelState.IsValid)
            {
                service.CreateExternal(ex);
                return RedirectToAction("Index");
            }
            return View(ex);
        }

        // GET: External/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new ExternalService();
            var detail = service.GetExternalById(id);
            var model = new ExternalEdit
            {
                Id = detail.Id,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Capacity = detail.Capacity,
                Interface = detail.Interface,
                Type = detail.Type,
                Color = detail.Color,
                IsPortiable = detail.IsPortiable,
                IsAvailable = detail.IsAvailable
            };
            return View(model);
        }

        // POST: External/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ExternalEdit model)
        {
            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new ExternalService();

            if (service.UpdateExternal(model))
            {
                TempData["SaveResult"] = "Your External drive information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your External drive information could not be updated.");
            return View();
        }

        // GET: External/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new ExternalService();
            var model = service.GetExternalById(id);

            if(model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: External/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteExternal(int id)
        {
            var service = new ExternalService();

            service.DeleteExternal(id);

            TempData["SaveResult"] = "Your External drive entry was deleted.";
            return RedirectToAction("Index");
        }
    }
}
