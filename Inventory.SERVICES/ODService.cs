using Inventory.DATA;
using Inventory.MODELS.OpticalDriveModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class ODService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // Create
        public bool CreateOD(ODCreate model)
        {
            OpticalDrive entity = new OpticalDrive
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                FormFactor = model.FormFactor,
                Interface = model.Interface,
                Capability = model.Capability,
                Color = model.Color,
                BufferCache = model.BufferCache,
                IsAvailable = model.IsAvailable
            };
            _db.OpticalDrives.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get ALL
        public List<ODListItem> GetAllODs()
        {
            var ODEntities = _db.OpticalDrives.ToList();
            var ODList = ODEntities.Select(c => new ODListItem
            {
                Name = c.Name,
                Manufacturer = c.Manufacturer,
                Interface = c.Interface,
                Capability = c.Capability,
                Color = c.Color,
                IsAvailable = c.IsAvailable
            }).ToList();
            return ODList;
        }

        //Get (Details by ID)
        public ODDetail GetODById(int ODId)
        {
            using(var _db = new ApplicationDbContext())
            {
                var ODEntity =
                    _db
                    .OpticalDrives
                    .SingleOrDefault(e => e.Id == ODId);
                return
                    new ODDetail
                    {
                        Name = ODEntity.Name,
                        Manufacturer = ODEntity.Manufacturer,
                        FormFactor = ODEntity.FormFactor,
                        Interface = ODEntity.Interface,
                        Capability = ODEntity.Capability,
                        Color = ODEntity.Color,
                        BufferCache = ODEntity.BufferCache,
                        IsAvailable = ODEntity.IsAvailable
                    };
            }
        }
        public bool UpdateOD(ODEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var ODEntity =
                    _db
                    .OpticalDrives
                    .SingleOrDefault(e => e.Id == model.Id);
                ODEntity.Name = model.Name;
                ODEntity.Manufacturer = model.Manufacturer;
                ODEntity.FormFactor = model.FormFactor;
                ODEntity.Interface = model.Interface;
                ODEntity.Capability = model.Capability;
                ODEntity.Color = model.Color;
                ODEntity.BufferCache = model.BufferCache;
                ODEntity.IsAvailable = model.IsAvailable;

                return _db.SaveChanges() == 1;
            }
        }
        public bool DeleteOD(int ODId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .OpticalDrives
                        .SingleOrDefault(e => e.Id == ODId);

                _db.OpticalDrives.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
