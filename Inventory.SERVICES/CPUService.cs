using Inventory.DATA;
using Inventory.MODELS.CPUModels;
using System.Collections.Generic;
using System.Linq;

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
                CpuId = c.CpuId,
                Name = c.Name,
                CoreCount = c.CoreCount,
                CoreClock = c.CoreClock,
                BoostClock = c.BoostClock,
                Socket = c.Socket,
                IsAvailable = c.IsAvailable
            }).ToList();
            return cpuList;
        }

        // Get (Details by CpuId)
        public CPUDetail GetCpuById(int cpuId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var cpuEntity =
                    _db
                    .CPUs
                    .SingleOrDefault(e => e.CpuId == cpuId);
                return
                new CPUDetail
                {
                    CpuId = cpuEntity.CpuId,
                    Name = cpuEntity.Name,
                    Manufacturer = cpuEntity.Manufacturer,
                    CoreCount = cpuEntity.CoreCount,
                    CoreClock = cpuEntity.CoreClock,
                    BoostClock = cpuEntity.BoostClock,
                    Series = cpuEntity.Series,
                    CoreFamily = cpuEntity.CoreFamily,
                    Socket = cpuEntity.Socket,
                    IsAvailable = cpuEntity.IsAvailable,
                    MicroArchitecture = cpuEntity.MicroArchitecture,
                    ThermalDesignPower = cpuEntity.ThermalDesignPower,
                    IntegratedGraphics = cpuEntity.IntegratedGraphics,
                    SimultaneousMultithreading = cpuEntity.SimultaneousMultithreading
                };
            }

        }
        public bool UpdateCpu(CPUEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var cpuEntity =
                    _db
                        .CPUs
                        .SingleOrDefault(e => e.CpuId == model.CpuId);

                cpuEntity.CpuId = model.CpuId;
                cpuEntity.Name = model.Name;
                cpuEntity.Manufacturer = model.Manufacturer;
                cpuEntity.CoreCount = model.CoreCount;
                cpuEntity.CoreClock = model.CoreClock;
                cpuEntity.BoostClock = model.BoostClock;
                cpuEntity.Series = model.Series;
                cpuEntity.CoreFamily = model.CoreFamily;
                cpuEntity.Socket = model.Socket;
                cpuEntity.IsAvailable = model.IsAvailable;
                cpuEntity.MicroArchitecture = model.MicroArchitecture;
                cpuEntity.ThermalDesignPower = model.ThermalDesignPower;
                cpuEntity.IntegratedGraphics = model.IntegratedGraphics;
                cpuEntity.SimultaneousMultithreading = model.SimultaneousMultithreading;

                return _db.SaveChanges() == 1;
            }
        }

        // Delete by CpuId
        public bool DeleteCpu(int cpuId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .CPUs
                        .SingleOrDefault(e => e.CpuId == cpuId);

                _db.CPUs.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
