using Inventory.DATA;
using Inventory.MODELS.InternalStorageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class InternalService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        // Create
        public bool CreateInternal(InternalCreate model)
        {
            InternalStorage entity = new InternalStorage
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Interface = model.Interface,
                Capacity = model.Capacity,
                Type = model.Type,
                FormFactor = model.Type,
                NVME = model.NVME,
                IsAvailable = model.IsAvailable
            };
            _db.InternalStorages.Add(entity);
            return _db.SaveChanges() == 1;

        }

        // Get ALL
        public IEnumerable<InternalListItem> GetAllInternals()
        {
            var InternalEntities = _db.InternalStorages.ToList();
            var InternalList = InternalEntities.Select(c => new InternalListItem
            {
                Id = c.Id,
                Name = c.Name,
                Interface = c.Interface,
                Capacity = c.Capacity,
                IsAvailable = c.IsAvailable,
            }).ToList();
            return InternalList;
        }

        // Get (Details by ID)
        public InternalDetail GetInternalById(int InternalId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var InternalEntity =
                    _db
                    .InternalStorages
                    .SingleOrDefault(e => e.Id == InternalId);
                return
                new InternalDetail
                {
                    Id = InternalEntity.Id,
                    Name = InternalEntity.Name,
                    Manufacturer = InternalEntity.Manufacturer,
                    Interface = InternalEntity.Interface,
                    Capacity = InternalEntity.Capacity,
                    Type = InternalEntity.Type,
                    FormFactor = InternalEntity.FormFactor,
                    NVME = InternalEntity.NVME,
                    IsAvailable = InternalEntity.IsAvailable,
                };
            }

        }
        public bool UpdateInternal(InternalEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var InternalEntity =
                    _db
                        .InternalStorages
                        .SingleOrDefault(e => e.Id == model.Id);

                InternalEntity.Id = model.Id;
                InternalEntity.Name = model.Name;
                InternalEntity.Manufacturer = model.Manufacturer;
                InternalEntity.Interface = model.Interface;
                InternalEntity.Capacity = model.Capacity;
                InternalEntity.Type = model.Type;
                InternalEntity.FormFactor = model.FormFactor;
                InternalEntity.NVME = model.NVME;
                InternalEntity.IsAvailable = model.IsAvailable;
                return _db.SaveChanges() == 1;
            }
        }

        // Delete by ID
        public bool DeleteInternal(int InternalId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .InternalStorages
                        .SingleOrDefault(e => e.Id == InternalId);

                _db.InternalStorages.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
