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
        
        // GET : CPU/Edit/{id}
        
        // GET : CPU/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var service = new CPUService();
            var model = service.GetCpuById(id);
            
            if(model == null)
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