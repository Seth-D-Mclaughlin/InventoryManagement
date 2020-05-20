using Inventory.DATA;
using Inventory.SERVICES;
using Inventory.MODELS.CPUModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace Inventory.MVC.Controllers.HARDWARE_Controllers
{
    public class CPUController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: CPU
        public ActionResult Index()
        {
            var service = new CPUService();
            var cpuList = service.GetAllCPUs();
            return View(cpuList);
        }

        // GET : CPU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST : CPU/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CPUCreate cpu)
        {
            var service = new CPUService();
            if (ModelState.IsValid)
            {
                service.CreateCPU(cpu);
                return RedirectToAction("Index");
            }
            return View(cpu);
        }

        // GET : CPU/Details/{id}
        public ActionResult Details(int? id)
        {
            var service = new CPUService();
            var model = service.GetCpuById(id);
            return View(model);
        }

        // GET : CPU/Edit/{id}
        public ActionResult Edit(int id)
        {
            var service = new CPUService();
            var detail = service.GetCpuById(id);
            var model = new CPUEdit
            {
                Id = detail.Id,
                Manufacturer=detail.Manufacturer,
                Series=detail.Series,
                CoreFamily = detail.CoreFamily,
                Name = detail.Name,
                CoreCount = detail.CoreCount,
                CoreClock = detail.CoreClock,
                BoostClock = detail.BoostClock,
                Socket = detail.Socket,
                IsAvailable = detail.IsAvailable,
                MicroArchitecture = detail.MicroArchitecture,
                ThermalDesignPower = detail.ThermalDesignPower,
                IntegratedGraphics = detail.IntegratedGraphics,
                SimultaneousMultithreading = detail.SimultaneousMultithreading
            };
            return View(model);
        }
        // POST: CPU/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, CPUEdit model)
        {
            

            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new CPUService();

            if (service.UpdateCpu(model))
            {
                TempData["SaveResult"] = "Your CPU information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your CPU information could not be updated.");
            return View();
        }
        // GET : CPU/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var service = new CPUService();
            var model = service.GetCpuById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        // POST : CPU/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var service = new CPUService();

            service.DeleteCpu(id);

            TempData["SaveResult"] = "Your CPU entry was deleted.";
            return RedirectToAction("Index");
        }

    }
}