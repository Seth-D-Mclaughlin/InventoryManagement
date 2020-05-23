using Inventory.DATA;
using Inventory.MODELS.CPUCoolerModels;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.SERVICES
{
    public class CPUCoolerService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();


        // Create
        public bool CreateCPUCooler(CPUCooler model)
        {
            CPUCooler entity = new CPUCooler
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Color = model.Color,
                Height = model.Height,
                Bearing = model.Bearing,
                Socket = model.Socket,
                WaterCooled = model.WaterCooled,
                Fanless = model.Fanless,
                IsAvailable = model.IsAvailable
            };
            _db.CPUCoolers.Add(entity);
            return _db.SaveChanges() == 1;
        }

        //Get ALL
        public List<CPUCoolerListItem> GetAllCPUCoolers()
        {
            var cpuCoolerEntities = _db.CPUCoolers.ToList();
            var cpuCoolerList = cpuCoolerEntities.Select(c => new CPUCoolerListItem
            {
                Name = c.Name,
                Color = c.Color,
                Socket = c.Socket,
                WaterCooled = c.WaterCooled,
                IsAvailable = c.IsAvailable
            }).ToList();
            return cpuCoolerList;
        }

        // Get (Details by ID)
        public CPUCoolerDetail GetCPUCoolerById(int coolerId)
        {
            var coolerEntity = _db.CPUCoolers.Find(coolerId);
            var coolerDetail = new CPUCoolerDetail
            {
                Name = coolerEntity.Name,
                Manufacturer = coolerEntity.Manufacturer,
                Color = coolerEntity.Color,
                Height = coolerEntity.Height,
                Bearing = coolerEntity.Bearing,
                Socket = coolerEntity.Socket,
                WaterCooled = coolerEntity.WaterCooled,
                Fanless = coolerEntity.Fanless,
                IsAvailable = coolerEntity.IsAvailable
            };
            return coolerDetail;
        }
    }
}
