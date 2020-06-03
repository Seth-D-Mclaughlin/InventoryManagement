using Inventory.DATA;
using Inventory.MODELS.ExternalStorageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class ExternalService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        // Create
        public bool CreateExternal(ExternalCreate model)
        {
            ExternalStorage entity = new ExternalStorage
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Interface = model.Interface,
                Capacity = model.Capacity,
                Type = model.Type,
                Color = model.Color,
                IsPortiable = model.IsPortiable,
                IsAvailable = model.IsAvailable
            };
            _db.ExternalStorages.Add(entity);
            return _db.SaveChanges() == 1;

        }

        // Get ALL
        public IEnumerable<ExternalListItem> GetAllExternals()
        {
            var ExternalEntities = _db.ExternalStorages.ToList();
            var ExternalList = ExternalEntities.Select(c => new ExternalListItem
            {
                Id = c.StorageId,
                Name = c.Name,
                Interface = c.Interface,
                Capacity = c.Capacity,
                IsPortiable = c.IsPortiable,
                IsAvailable = c.IsAvailable
            }).ToList();
            return ExternalList;
        }

        // Get (Details by ID)
        public ExternalDetail GetExternalById(int ExternalId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var ExternalEntity =
                    _db
                    .ExternalStorages
                    .SingleOrDefault(e => e.StorageId == ExternalId);
                return
                new ExternalDetail
                {
                    Id = ExternalEntity.StorageId,
                    Name = ExternalEntity.Name,
                    Manufacturer = ExternalEntity.Manufacturer,
                    Interface = ExternalEntity.Interface,
                    Capacity = ExternalEntity.Capacity,
                    Type = ExternalEntity.Type,
                    Color = ExternalEntity.Color,
                    IsPortiable = ExternalEntity.IsPortiable,
                    IsAvailable = ExternalEntity.IsAvailable,
                   
                };
            }

        }
        public bool UpdateExternal(ExternalEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var ExternalEntity =
                    _db
                        .ExternalStorages
                        .SingleOrDefault(e => e.StorageId == model.Id);

                ExternalEntity.StorageId = model.Id;
                ExternalEntity.Name = model.Name;
                ExternalEntity.Manufacturer = model.Manufacturer;
                ExternalEntity.Interface = model.Interface;
                ExternalEntity.Capacity = model.Capacity;
                ExternalEntity.Type = model.Type;
                ExternalEntity.Color = model.Color;
                ExternalEntity.IsPortiable = model.IsPortiable;
                ExternalEntity.IsAvailable = model.IsAvailable;
                return _db.SaveChanges() == 1;
            }
        }

        // Delete by ID
        public bool DeleteExternal(int ExternalId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .ExternalStorages
                        .SingleOrDefault(e => e.StorageId == ExternalId);

                _db.ExternalStorages.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
