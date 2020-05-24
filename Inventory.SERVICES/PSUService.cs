using Inventory.DATA;
using Inventory.MODELS.PSUModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class PSUService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();


        //Create
        public bool CreatePSU(PSUCreate model)
        {
            PowerSupplyUnit entity = new PowerSupplyUnit
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                EffeciencyRating = model.EffeciencyRating,
                Type = model.Type,
                TypeOfModular = model.TypeOfModular,
                Color = model.Color,
                Fanless = model.Fanless,
                ATXConnectors = model.ATXConnectors,
                IsAvailable = model.IsAvailable
            };
            _db.PowerSupplyUnits.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get All
        public IEnumerable<PSUListItem> GetAllPowerSupplyUnits()
        {
            var PSUEntites = _db.PowerSupplyUnits.ToList();
            var PSUList = PSUEntites.Select(m => new PSUListItem
            {
                Id = m.Id,
                Name = m.Name,
                Manufacturer = m.Manufacturer,
                Type = m.Type,
                ATXConnectors = m.ATXConnectors,
                IsAvailable = m.IsAvailable
            }).ToList();
            return PSUList;
        }

        // Get (Details by ID)
        public PSUDetail GetPSUById(int? psuId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var PSUEntity =
                    _db
                    .PowerSupplyUnits
                    .SingleOrDefault(e => e.Id == psuId);
                return
                    new PSUDetail
                    {
                        Id = PSUEntity.Id,
                        Name = PSUEntity.Name,
                        Manufacturer = PSUEntity.Manufacturer,
                        Type = PSUEntity.Type,
                        EffeciencyRating = PSUEntity.EffeciencyRating,
                        TypeOfModular = PSUEntity.TypeOfModular,
                        Color = PSUEntity.Color,
                        Fanless = PSUEntity.Fanless,
                        ATXConnectors = PSUEntity.ATXConnectors,
                        IsAvailable = PSUEntity.IsAvailable
                    };

            }
        }
        public bool UpdatePSU(PSUEdit model)
        {
            using (_db)
            {
                var PSUEntity =
                    _db
                    .PowerSupplyUnits
                    .SingleOrDefault(e => e.Id == model.Id);
                PSUEntity.Name = model.Name;
                PSUEntity.Manufacturer = model.Manufacturer;
                PSUEntity.Type = model.Type;
                PSUEntity.EffeciencyRating = model.EffeciencyRating;
                PSUEntity.TypeOfModular = model.TypeOfModular;
                PSUEntity.Color = model.Color;
                PSUEntity.Fanless = model.Fanless;
                PSUEntity.ATXConnectors = model.ATXConnectors;
                PSUEntity.IsAvailable = model.IsAvailable;

                return _db.SaveChanges() == 1;
            }
        }

        // Delete by ID
        public bool DeletePSU(int psuId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .PowerSupplyUnits
                        .SingleOrDefault(e => e.Id == psuId);

                _db.PowerSupplyUnits.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
