using Inventory.DATA;
using Inventory.MODELS.MemeoryModels;
using Inventory.SERVICES;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers.HARDWARE_Controllers
{
    public class MemoryController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Memory
        public ActionResult Index()
        {
            var service = new MemoryService();
            var memList = service.GetAllMemories();
            return View(memList);
        }

        // GET: Memory/Details/5
        public ActionResult Details(int id)
        {
            var service = new MemoryService();
            var model = service.GetMemoryById(id);
            return View(model);
        }

        // GET: Memory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemoryCreate mem)
        {
            var service = new MemoryService();
            if (ModelState.IsValid)
            {
                service.CreateMemory(mem);
                return RedirectToAction("Index");
            }
            return View(mem);

        }

        // GET: Memory/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new MemoryService();
            var detail = service.GetMemoryById(id);
            var model = new MemoryEdit
            {
                MemoryId = detail.Id,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Speed = detail.Speed,
                Type = detail.Type,
                Modules = detail.Modules,
                CASLatency = detail.CASLatency,
                Voltage = detail.Voltage,
                Timing = detail.Timing,
                HeatSpreader = detail.HeatSpreader,
                IsAvailable = detail.IsAvailable
            };
            return View(model);
        }

        // POST: Memory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MemoryEdit model)
        {
            if (model.MemoryId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = new MemoryService();
            if (service.UpdateMemory(model))
            {
                TempData["SaveResult"] = "Your Memory information was updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your Memory information could not be updated.");
            return View();
        }


        // GET: Memory/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new MemoryService();
            var model = service.GetMemoryById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Memory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteMemory(int id)
        {
            var service = new MemoryService();
            service.DeleteMemory(id);
            TempData["SaveResult"] = "Your Memory entry was deleted.";

            return RedirectToAction("Index");
        }
    }
}

