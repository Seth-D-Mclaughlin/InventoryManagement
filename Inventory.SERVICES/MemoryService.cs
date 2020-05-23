using Inventory.DATA;
using Inventory.MODELS.MemeoryModels;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.SERVICES
{
    public class MemoryService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();


        //Create
        public bool CreateMemory(MemoryCreate model)
        {
            Memory entity = new Memory
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Speed = model.Speed,
                Type = model.Type,
                Modules = model.Modules,
                CASLatency = model.CASLatency,
                Voltage = model.Voltage,
                Timing = model.Timing,
                HeatSpreader = model.HeatSpreader,
                IsAvailable = model.IsAvailable
            };
            _db.Memories.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get All
        public IEnumerable<MemoryListItem> GetAllMemories()
        {
            var memoryEntites = _db.Memories.ToList();
            var memoryList = memoryEntites.Select(m => new MemoryListItem
            {
                Id = m.Id,
                Name = m.Name,
                Manufacturer = m.Manufacturer,
                Speed = m.Speed,
                IsAvailable = m.IsAvailable
            }).ToList();
            return memoryList;
        }

        // Get (Details by ID)
        public MemoryDetail GetMemoryById(int? memId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var memoryEntity =
                    _db
                    .Memories
                    .SingleOrDefault(e => e.Id == memId);
                return
                    new MemoryDetail
                    {
                        Id = memoryEntity.Id,
                        Name = memoryEntity.Name,
                        Manufacturer = memoryEntity.Manufacturer,
                        Speed = memoryEntity.Speed,
                        Type = memoryEntity.Type,
                        Modules = memoryEntity.Modules,
                        CASLatency = memoryEntity.CASLatency,
                        Voltage = memoryEntity.Voltage,
                        Timing = memoryEntity.Timing,
                        HeatSpreader = memoryEntity.HeatSpreader,
                        IsAvailable = memoryEntity.IsAvailable
                    };

            }
        }
        public bool UpdateMemory(MemoryEdit model)
        {
            using (_db)
            {
                var memEntity =
                    _db
                    .Memories
                    .SingleOrDefault(e => e.Id == model.Id);
                memEntity.Name = model.Name;
                memEntity.Manufacturer = model.Manufacturer;
                memEntity.Speed = model.Speed;
                memEntity.Type = model.Type;
                memEntity.Modules = model.Modules;
                memEntity.CASLatency = model.CASLatency;
                memEntity.Voltage = model.Voltage;
                memEntity.Timing = model.Timing;
                memEntity.HeatSpreader = model.HeatSpreader;
                memEntity.IsAvailable = model.IsAvailable;

                return _db.SaveChanges() == 1;
            }
        }

        // Delete by ID
        public bool DeleteMemory(int memId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .Memories
                        .SingleOrDefault(e => e.Id == memId);

                _db.Memories.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}

