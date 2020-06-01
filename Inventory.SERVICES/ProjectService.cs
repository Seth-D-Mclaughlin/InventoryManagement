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
                CPU = model.CpuName,
            }
        }
    }
}
