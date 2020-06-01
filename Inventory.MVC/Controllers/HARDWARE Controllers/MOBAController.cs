using Inventory.MODELS.MotherboardModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers.HARDWARE_Controllers
{
    public class MOBAController : Controller
    {
        // GET: MOBA
        public ActionResult Index()
        {
            var service = new MOBAService();
            var mobaList = service.GetAllMOBAs();
            return View(mobaList);
        }

        // GET: MOBA/Details/5
        public ActionResult Details(int id)
        {
            var service = new MOBAService();
            var model = service.GetMOBAById(id);
            return View(model);
        }

        // GET: MOBA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MOBA/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MOBACreate moba)
        {
            var service = new MOBAService();
            if (ModelState.IsValid)
            {
                service.CreateMOBA(moba);
                return RedirectToAction("Index");
            }
            return View(moba);
        }

        // GET: MOBA/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new MOBAService();
            var detail = service.GetMOBAById(id);
            var model = new MOBAEdit
            {
                MotherboardId = detail.MotherboardId,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Socket = detail.Socket,
                FormFactor = detail.FormFactor,
                MemoryMax = detail.MemoryMax,
                MemorySlots = detail.MemorySlots,
                Color = detail.Color,
                Chipset = detail.Chipset,
                PCIEX16Slots = detail.PCIEX16Slots,
                PCIEX8Slots = detail.PCIEX8Slots,
                PCIEX4Slots = detail.PCIEX4Slots,
                PCISlots = detail.PCISlots,
                EthernetPorts = detail.EthernetPorts,
                M2Slots = detail.M2Slots,
                Sata3GBsPorts = detail.Sata3GBsPorts,
                Sata6GBsPorts = detail.Sata6GBsPorts,
                SataExpressPorts = detail.MSataSlots,
                OnboardVideo = detail.OnboardVideo,
                OnboardUSB3Headers = detail.OnboardUSB3Headers,
                WifiNetworking = detail.WifiNetworking,
                IsAvailable = detail.IsAvailable,
            };
            return View(model);
            }
        // POST: MOBA/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MOBAEdit model)
        {
            if (model.MotherboardId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new MOBAService();

            if (service.UpdateMOBA(model))
            {
                TempData["SaveResult"] = "Your Motherboard information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Motherboard information could not be updated.");
            return View();
        }

        // GET: MOBA/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new MOBAService();
            var model = service.GetMOBAById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: MOBA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteMOBA(int id)
        {
            var service = new MOBAService();
            service.DeleteMOBA(id);
            TempData["SaveResult"] = "Your Motherboard entry was deleted.";
            return RedirectToAction("Index");
        }
    }
}
