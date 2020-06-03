using Inventory.MODELS.CPUModels;
using Inventory.MODELS.ProjectModels;
using Inventory.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.MVC.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            var service = new ProjectService();
            var projectList = service.GetAllProjects();
            return View(projectList);
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            var service = new ProjectService();
            var model = service.GetProjectById(id);
            return View(model);
        }

        // GET: Project/Create
        public ActionResult Create()
        {   //create a List of objects through calling your service
            //Store that List in a Viewbag as one of 3-4 parameters of a SelectList object
            //@Html.DropDownList() in your view

            var cpuDb = new CPUService();
            ViewBag.CpuId = new SelectList(cpuDb.GetAllCPUs().ToList(), "CpuId", "Name");


            var memDb = new MemoryService();
            ViewBag.MemoryId = new SelectList(memDb.GetAllMemories().ToList(), "MemoryId", "Name");

            var caseDb = new CaseService();
            ViewBag.CaseId = new SelectList(caseDb.GetAllCases().ToList(), "CaseId", "Name");

            var videoDb = new VideoCardService();
            ViewBag.VideoId = new SelectList(videoDb.GetAllVideoCards().ToList(), "VideoId", "Name");

            var mobaDb = new MOBAService();
            ViewBag.MotherboardId = new SelectList(mobaDb.GetAllMOBAs().ToList(), "MotherboardId", "Name");

            var psuDb = new PSUService();
            ViewBag.PsuId = new SelectList(psuDb.GetAllPowerSupplyUnits().ToList(), "PsuId", "Name");

            return View();

        }

        // POST: Project/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectCreate model)
        {
            var service = new ProjectService();
            if (ModelState.IsValid)
            {
                service.CreateProject(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            var cpuDb = new CPUService();
            ViewBag.CpuId = new SelectList(cpuDb.GetAllCPUs().ToList(), "CpuId", "Name");


            var memDb = new MemoryService();
            ViewBag.MemoryId = new SelectList(memDb.GetAllMemories().ToList(), "MemoryId", "Name");

            var caseDb = new CaseService();
            ViewBag.CaseId = new SelectList(caseDb.GetAllCases().ToList(), "CaseId", "Name");

            var videoDb = new VideoCardService();
            ViewBag.VideoId = new SelectList(videoDb.GetAllVideoCards().ToList(), "VideoId", "Name");

            var mobaDb = new MOBAService();
            ViewBag.MotherboardId = new SelectList(mobaDb.GetAllMOBAs().ToList(), "MotherboardId", "Name");

            var psuDb = new PSUService();
            ViewBag.PsuId = new SelectList(psuDb.GetAllPowerSupplyUnits().ToList(), "PsuId", "Name");

            
            var service = new ProjectService();
            var detail = service.GetProjectById(id);
            var model = new ProjectEdit
            {
                ProjectId = detail.ProjectId,
                Name = detail.Name,
                Description = detail.Description,
                Notes = detail.Notes,
                CpuId = detail.CpuId,
                CPU = detail.CPU,
                MemoryId = detail.MemoryId,
                Memory = detail.Memory,
                CaseId = detail.CaseId,
                Case = detail.Case,
                VideoId = detail.VideoId,
                VideoCard = detail.VideoCard,
                MotherboardId = detail.MotherboardId,
                Motherboard = detail.Motherboard,
                PsuId = detail.PsuId,
                PowerSupplyUnit = detail.PowerSupplyUnit
            };
            return View(model);
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProjectEdit model)
        {
            if (model.ProjectId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = new ProjectService();

            if (service.UpdateProject(model))
            {
                TempData["SaveResult"] = "Your Project information was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Project information could not be updated.");
            return View();
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            var service = new ProjectService();
            var model = service.GetProjectById(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteProject(int id)
        {
            var service = new ProjectService();
            service.DeleteProject(id);

            TempData["SaveResult"] = "Your CPU entry was deleted.";
            return RedirectToAction("Index");
        }
    }
}
