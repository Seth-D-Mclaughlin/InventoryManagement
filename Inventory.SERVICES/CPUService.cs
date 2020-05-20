using Inventory.DATA;
using Inventory.MODELS.CPUModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class CPUService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();


        // Create
        public bool CreateCPU(CPUCreate model)
        {
            CPU entity = new CPU
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                CoreFamily = model.CoreFamily,
                CoreCount = model.CoreCount,
                CoreClock = model.CoreClock,
                BoostClock = model.BoostClock,
                Series = model.Series,
                Socket = model.Socket,
                MicroArchitecture = model.MicroArchitecture,
                ThermalDesignPower = model.ThermalDesignPower,
                IntegratedGraphics = model.IntegratedGraphics,
                SimultaneousMultithreading = model.SimultaneousMultithreading,
                IsAvailable = model.IsAvailable
            };
            _db.CPUs.Add(entity);
            return _db.SaveChanges() == 1;

        }

        // Get ALL
        public IEnumerable<CPUListItem> GetAllCPUs()
        {
            var cpuEntities = _db.CPUs.ToList();
            var cpuList = cpuEntities.Select(c => new CPUListItem
            {
                Id = c.Id,
                Name = c.Name,
                CoreCount = c.CoreCount,
                CoreClock = c.CoreClock,
                BoostClock = c.BoostClock,
                Socket = c.Socket,
                IsAvailable = c.IsAvailable
            }).ToList();
            return cpuList;
        }

        // Get (Details by ID)
        public CPUDetail GetCpuById(int? cpuId)
        {
            var cpuEntity = _db.CPUs.Find(cpuId);
            var cpuDetail = new CPUDetail
            {
                Id = cpuEntity.Id,
                Name = cpuEntity.Name,
                CoreCount = cpuEntity.CoreCount,
                CoreClock = cpuEntity.CoreClock,
                BoostClock = cpuEntity.BoostClock,
                Socket = cpuEntity.Socket,
                IsAvailable = cpuEntity.IsAvailable,
                MicroArchitecture = cpuEntity.MicroArchitecture,
                ThermalDesignPower = cpuEntity.ThermalDesignPower,
                IntegratedGraphics = cpuEntity.IntegratedGraphics,
                SimultaneousMultithreading = cpuEntity.SimultaneousMultithreading
            };
            return cpuDetail;
        }

        // Delete by ID
        public bool DeleteCpu(int cpuId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .CPUs
                        .SingleOrDefault(e => e.Id == cpuId );

                _db.CPUs.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
