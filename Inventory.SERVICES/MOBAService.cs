using Inventory.DATA;
using Inventory.MODELS.MotherboardModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class MOBAService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // Create
        public bool CreateMOBA(MOBACreate model)
        {
            Motherboard entity = new Motherboard
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Color = model.Color,
                Socket = model.Socket,
                FormFactor = model.FormFactor,
                MemoryMax = model.MemoryMax,
                MemorySlots = model.MemorySlots,
                Chipset = model.Chipset,
                PCIEX16Slots = model.PCIEX16Slots,
                PCIEX8Slots = model.PCIEX8Slots,
                PCIEX4Slots = model.PCIEX4Slots,
                PCISlots = model.PCISlots,
                EthernetPorts = model.EthernetPorts,
                M2Slots = model.M2Slots,
                Sata3GBsPorts = model.Sata3GBsPorts,
                Sata6GBsPorts = model.Sata6GBsPorts,
                SataExpressPorts = model.SataExpressPorts,
                MSataSlots = model.MSataSlots,
                OnboardVideo = model.OnboardVideo,
                OnboardUSB3Headers = model.OnboardUSB3Headers,
                WifiNetworking = model.WifiNetworking,
                IsAvailable = model.IsAvailable
            };
            _db.Motherboards.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get ALL
        public List<MOBAListItem> GetAllMOBAs()
        {
            var MOBAEntities = _db.Motherboards.ToList();
            var MOBAList = MOBAEntities.Select(c => new MOBAListItem
            {
                Id = c.Id,
                Name = c.Name,
                Manufacturer = c.Manufacturer,
                Socket = c.Socket,
                FormFactor = c.FormFactor,
                MemorySlots = c.MemorySlots,
                IsAvailable = c.IsAvailable

            }).ToList();
            return MOBAList;
        }

        // Get (Details by ID)
        public MOBADetail GetMOBAById(int MOBAId)
        {
            using (var _db = new ApplicationDbContext())
            {
                var MOBAEntity =
                    _db
                    .Motherboards
                    .SingleOrDefault(e => e.Id == MOBAId);
                return
                new MOBADetail
                {
                    Id = MOBAEntity.Id,
                    Name = MOBAEntity.Name,
                    Manufacturer = MOBAEntity.Manufacturer,
                    Color = MOBAEntity.Color,
                    Socket = MOBAEntity.Socket,
                    FormFactor = MOBAEntity.FormFactor,
                    MemoryMax = MOBAEntity.MemoryMax,
                    MemorySlots = MOBAEntity.MemorySlots,
                    Chipset = MOBAEntity.Chipset,
                    PCIEX16Slots = MOBAEntity.PCIEX16Slots,
                    PCIEX8Slots = MOBAEntity.PCIEX8Slots,
                    PCIEX4Slots = MOBAEntity.PCIEX4Slots,
                    PCISlots = MOBAEntity.PCISlots,
                    EthernetPorts = MOBAEntity.EthernetPorts,
                    M2Slots = MOBAEntity.M2Slots,
                    Sata3GBsPorts = MOBAEntity.Sata3GBsPorts,
                    Sata6GBsPorts = MOBAEntity.Sata6GBsPorts,
                    SataExpressPorts = MOBAEntity.SataExpressPorts,
                    MSataSlots = MOBAEntity.MSataSlots,
                    OnboardVideo = MOBAEntity.OnboardVideo,
                    OnboardUSB3Headers = MOBAEntity.OnboardUSB3Headers,
                    WifiNetworking = MOBAEntity.WifiNetworking,
                    IsAvailable = MOBAEntity.IsAvailable
                };
            }
        }
        public bool UpdateMOBA(MOBAEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var MOBAEntity =
                    _db
                    .Motherboards
                    .SingleOrDefault(e => e.Id == model.Id);
                MOBAEntity.Name = model.Name;
                MOBAEntity.Manufacturer = model.Manufacturer;
                MOBAEntity.Color = model.Color;
                MOBAEntity.Socket = model.Socket;
                MOBAEntity.FormFactor = model.FormFactor;
                MOBAEntity.MemoryMax = model.MemoryMax;
                MOBAEntity.MemorySlots = model.MemorySlots;
                MOBAEntity.Chipset = model.Chipset;
                MOBAEntity.PCIEX16Slots = model.PCIEX16Slots;
                MOBAEntity.PCIEX8Slots = model.PCIEX8Slots;
                MOBAEntity.PCIEX4Slots = model.PCIEX4Slots;
                MOBAEntity.PCISlots = model.PCISlots;
                MOBAEntity.EthernetPorts = model.EthernetPorts;
                MOBAEntity.M2Slots = model.M2Slots;
                MOBAEntity.Sata3GBsPorts = model.Sata3GBsPorts;
                MOBAEntity.Sata6GBsPorts = model.Sata6GBsPorts;
                MOBAEntity.SataExpressPorts = model.SataExpressPorts;
                MOBAEntity.MSataSlots = model.MSataSlots;
                MOBAEntity.OnboardVideo = model.OnboardVideo;
                MOBAEntity.OnboardUSB3Headers = model.OnboardUSB3Headers;
                MOBAEntity.WifiNetworking = model.WifiNetworking;
                MOBAEntity.IsAvailable = model.IsAvailable;

                return _db.SaveChanges() == 1;
            }
        }
        // Delete by ID
        public bool DeleteMOBA(int MOBAId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .Motherboards
                        .SingleOrDefault(e => e.Id == MOBAId);

                _db.Motherboards.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
