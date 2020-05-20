using Inventory.DATA;
using Inventory.MODELS.CASEModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

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
                Id = c.Id,
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
            var caseEntity = _db.Cases.Find(caseId);
            var caseDetail = new CaseDetail
            {
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
            return caseDetail;
        }

    }
}
