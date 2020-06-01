using Inventory.DATA;
using Inventory.MODELS.ProjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class ProjectService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        //Create 
        public bool CreateProject(ProjectCreate model)
        {
            Project entity = new Project
            {
                Name = model.Name,
                Description = model.Description,
                Notes = model.Notes,
                CpuId = model.CpuId,
                CPU = model.CPU,
                MemoryId = model.MemoryId,
                Memory = model.Memory,
                CaseId = model.CaseId,
                Case = model.Case,
                CoolerId = model.CoolerId,
                CPUCooler = model.CPUCooler,
                VideoId = model.VideoId,
                VideoCard = model.VideoCard,
                MotherboardId = model.MotherboardId,
                Motherboard = model.Motherboard,
                PsuId = model.PsuId,
                PowerSupplyUnit = model.PowerSupplyUnit
            };
            _db.Projects.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get ALL
        public IEnumerable<ProjectListItem> GetAllProjects()
        {
            var ProjectEntities = _db.Projects.ToList();
            var projectList = ProjectEntities.Select(c => new ProjectListItem
            {
                Name = c.Name,
                Notes = c.Notes
            }).ToList();
            return projectList;
        }
        // Get (Details by CpuId)
        public ProjectDetail GetProjectById(int proId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var projectEntity =
                    _db
                    .Projects
                    .SingleOrDefault(e => e.ProjectId == proId);
                return
                new ProjectDetail
                {
                    Name = projectEntity.Name,
                    Description = projectEntity.Description,
                    Notes = projectEntity.Notes,
                    CpuId = projectEntity.CpuId,
                    CPU = projectEntity.CPU,
                    MemoryId = projectEntity.MemoryId,
                    Memory = projectEntity.Memory,
                    CaseId = projectEntity.CaseId,
                    Case = projectEntity.Case,
                    CoolerId = projectEntity.CoolerId,
                    CPUCooler = projectEntity.CPUCooler,
                    VideoId = projectEntity.VideoId,
                    VideoCard = projectEntity.VideoCard,
                    MotherboardId = projectEntity.MotherboardId,
                    Motherboard = projectEntity.Motherboard,
                    PsuId = projectEntity.PsuId,
                    PowerSupplyUnit = projectEntity.PowerSupplyUnit
                };
            }
        }
        public bool UpdateProject(ProjectEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var ProjectEntity =
                    _db
                        .Projects
                        .SingleOrDefault(e => e.ProjectId == model.ProjectId);

                ProjectEntity.Name = model.Name;
                ProjectEntity.CpuId = model.CpuId;
                ProjectEntity.CPU = model.CPU;
                ProjectEntity.MemoryId = model.MemoryId;
                ProjectEntity.Memory = model.Memory;
                ProjectEntity.CaseId = model.CaseId;
                ProjectEntity.Case = model.Case;
                ProjectEntity.CoolerId = model.CoolerId;
                ProjectEntity.CPUCooler = model.CPUCooler;
                ProjectEntity.VideoId = model.VideoId;
                ProjectEntity.VideoCard = model.VideoCard;
                ProjectEntity.MotherboardId = model.MotherboardId;
                ProjectEntity.Motherboard = model.Motherboard;
                ProjectEntity.PsuId = model.PsuId;
                ProjectEntity.PowerSupplyUnit = model.PowerSupplyUnit;
                

                return _db.SaveChanges() == 1;
            }
        }
        public bool DeleteProject(int projectId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .Projects
                        .SingleOrDefault(e => e.ProjectId == projectId);

                _db.Projects.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
