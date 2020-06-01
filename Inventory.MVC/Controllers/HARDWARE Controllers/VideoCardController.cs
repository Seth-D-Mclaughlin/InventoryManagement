using Inventory.DATA;
using Inventory.MODELS.VideoCardModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class VideoCardController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: VideoCard
        public ActionResult Index()
        {
            var service = new VideoCardService();
            var vidList = service.GetAllVideoCards();
            return View(vidList);
        }

        // GET: VideoCard/Details/5
        public ActionResult Details(int id)
        {
            var service = new VideoCardService();
            var model = service.GetVideoCardById(id);
            return View(model);
        }

        // GET: VideoCard/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoCard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VideoCardCreate vid)
        {
            var service = new VideoCardService();
            if (ModelState.IsValid)
            {
                service.CreateVideoCard(vid);
                return RedirectToAction("Index");
            }
            return View(vid);
        }


        // GET: VideoCard/Edit/5
        public ActionResult Edit(int id)
        {
            var service = new VideoCardService();
            var detail = service.GetVideoCardById(id);
            var model = new VideoCardEdit
            {
                VideoId = detail.VideoId,
                Name = detail.Name,
                Manufacturer = detail.Manufacturer,
                Chipset = detail.Chipset,
                MemoryType = detail.MemoryType,
                CoreClock = detail.CoreClock,
                BoostClock = detail.BoostClock,
                SLICrossfire = detail.SLICrossfire,
                FrameSync = detail.FrameSync,
                Length = detail.Length,
                ThermalDesignPower = detail.ThermalDesignPower,
                DVIPorts = detail.DVIPorts,
                HDMIPorts = detail.HDMIPorts,
                MiniHDMIPorts = detail.MiniHDMIPorts,
                DisplayPorts = detail.DisplayPorts,
                ExpansionSlotWidth = detail.ExpansionSlotWidth,
                Cooling = detail.Cooling,
                IsAvailable = detail.IsAvailable

            };
            return View(model);
        }

        // POST: VideoCard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, VideoCardEdit model)
        {
            if (model.VideoId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = new VideoCardService();
            if (service.UpdateVideoCard(model))
            {
                TempData["SaveResult"] = "Your Video Card information was updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your Video Card information could not be updated.");
            return View();
        }

        // GET: VideoCard/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new VideoCardService();
            var model = service.GetVideoCardById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: VideoCard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteVideoCard(int id)
        {
            var service = new VideoCardService();
            service.DeleteVideoCard(id);
            return RedirectToAction("Index");
        }
    }
}
