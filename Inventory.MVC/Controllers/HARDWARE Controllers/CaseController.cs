using Inventory.DATA;
using Inventory.MODELS.CASEModels;
using Inventory.SERVICES;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers.HARDWARE_Controllers
{
    public class CaseController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Case
        public ActionResult Index()
        {
            var service = new CaseService();
            var CaseList = service.GetAllCases();
            return View(CaseList);
        }

        // GET : Case/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST : Case/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CaseCreate Case)
        {
            var service = new CaseService();
            if (ModelState.IsValid)
            {
                service.CreateCase(Case);
                return RedirectToAction("Index");
            }
            return View(Case);
        }

        // GET : Case/Details/{id}
        public ActionResult Details(int id)
        {
            var service = new CaseService();
            var model = service.GetCaseById(id);
            return View(model);
        }

        // GET : Case/Edit/{id}
        public ActionResult Edit(int id)
        {
            var service = new CaseService();
            var detail = service.GetCaseById(id);
            var model = new CaseEdit
            {
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Color = detail.Color,
                PowerSupply = detail.PowerSupply,
                Type = detail.Type,
                SidePanelWindow = detail.SidePanelWindow,
                PowerSupplyShroud = detail.PowerSupplyShroud,
                FrontPanelUSB = detail.FrontPanelUSB,
                MotherboardFormFactor = detail.MotherboardFormFactor,
                External52Bay = detail.External52Bay,
                External35Bay = detail.External35Bay,
                Internal35Bay = detail.Internal35Bay,
                Internal25Bay = detail.Internal25Bay,
                FullHeightExpansionSlots = detail.FullHeightExpansionSlots,
                HalfHeightExpansionSlots = detail.HalfHeightExpansionSlots,
                IsAvailable = detail.IsAvailable
            };
            return View(model);
        }


        // POST: Case/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CaseEdit model)
        {

            if (model.CaseId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new CaseService();

            if (service.UpdateCase(model))
            {
                TempData["SaveResult"] = "Your Case information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Case information could not be updated.");
            return View();
        }

        // GET : Case/Delete/{id}
        public ActionResult Delete(int id)
        {

            var service = new CaseService();
            var model = service.GetCaseById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST : Case/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCase(int id)
        {
            var service = new CaseService();

            service.DeleteCase(id);

            TempData["SaveResult"] = "Your Case entry was deleted.";
            return RedirectToAction("Index");
        }
    }
}
