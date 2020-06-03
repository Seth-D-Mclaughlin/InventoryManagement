using Inventory.DATA;
using Inventory.MODELS.CASEModels;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.SERVICES
{
    public class CaseService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // Create
        public bool CreateCase(CaseCreate model)
        {
            Case entity = new Case
            {
                
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Color = model.Color,
                PowerSupply = model.PowerSupply,
                Type = model.Type,
                SidePanelWindow = model.SidePanelWindow,
                PowerSupplyShroud = model.PowerSupplyShroud,
                FrontPanelUSB = model.FrontPanelUSB,
                MotherboardFormFactor = model.MotherboardFormFactor,
                External52Bay = model.External52Bay,
                External35Bay = model.External35Bay,
                Internal35Bay = model.Internal35Bay,
                Internal25Bay = model.Internal25Bay,
                FullHeightExpansionSlots = model.FullHeightExpansionSlots,
                HalfHeightExpansionSlots = model.HalfHeightExpansionSlots,
                IsAvailable = model.IsAvailable
            };
            _db.Cases.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get ALL
        public List<CaseListItem> GetAllCases()
        {
            var caseEntities = _db.Cases.ToList();
            var caseList = caseEntities.Select(c => new CaseListItem
            {
                CaseId = c.CaseId,
                Name = c.Name,
                Type = c.Type,
                Color = c.Color,
                MotherboardFormFactor = c.MotherboardFormFactor,
                IsAvailable = c.IsAvailable

            }).ToList();
            return caseList;
        }

        // Get (Details by ID)
        public CaseDetail GetCaseById(int caseId)
        {
            using (var _db = new ApplicationDbContext())
            {
                var caseEntity =
                    _db
                    .Cases
                    .SingleOrDefault(e => e.CaseId == caseId);
                return
                new CaseDetail
                {
                    CaseId = caseEntity.CaseId,
                    Name = caseEntity.Name,
                    Manufacturer = caseEntity.Manufacturer,
                    Color = caseEntity.Color,
                    PowerSupply = caseEntity.PowerSupply,
                    Type = caseEntity.Type,
                    SidePanelWindow = caseEntity.SidePanelWindow,
                    PowerSupplyShroud = caseEntity.PowerSupplyShroud,
                    FrontPanelUSB = caseEntity.FrontPanelUSB,
                    MotherboardFormFactor = caseEntity.MotherboardFormFactor,
                    External52Bay = caseEntity.External52Bay,
                    External35Bay = caseEntity.External35Bay,
                    Internal35Bay = caseEntity.Internal35Bay,
                    Internal25Bay = caseEntity.Internal25Bay,
                    FullHeightExpansionSlots = caseEntity.FullHeightExpansionSlots,
                    HalfHeightExpansionSlots = caseEntity.HalfHeightExpansionSlots,
                    IsAvailable = caseEntity.IsAvailable
                };
            }
        }
        public bool UpdateCase(CaseEdit model)
        {
            using (var _db = new ApplicationDbContext())
            {
                var caseEntity =
                    _db
                    .Cases
                    .SingleOrDefault(e => e.CaseId == model.CaseId);
                caseEntity.Name = model.Name;
                caseEntity.Manufacturer = model.Manufacturer;
                caseEntity.Color = model.Color;
                caseEntity.PowerSupply = model.PowerSupply;
                caseEntity.Type = model.Type;
                caseEntity.SidePanelWindow = model.SidePanelWindow;
                caseEntity.PowerSupplyShroud = model.PowerSupplyShroud;
                caseEntity.FrontPanelUSB = model.FrontPanelUSB;
                caseEntity.MotherboardFormFactor = model.MotherboardFormFactor;
                caseEntity.External52Bay = model.External52Bay;
                caseEntity.External35Bay = model.External35Bay;
                caseEntity.Internal35Bay = model.Internal35Bay;
                caseEntity.Internal25Bay = model.Internal25Bay;
                caseEntity.FullHeightExpansionSlots = model.FullHeightExpansionSlots;
                caseEntity.HalfHeightExpansionSlots = model.HalfHeightExpansionSlots;
                caseEntity.IsAvailable = model.IsAvailable;

                return _db.SaveChanges() == 1;
            }
        }
        // Delete by ID
        public bool DeleteCase(int caseId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .Cases
                        .SingleOrDefault(e => e.CaseId == caseId);

                _db.Cases.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
