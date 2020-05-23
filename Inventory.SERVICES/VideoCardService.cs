using Inventory.DATA;
using Inventory.MODELS.VideoCardModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class VideoCardService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        //Create
        public bool CreateVideoCard(VideoCardCreate model)
        {
            VideoCard entity = new VideoCard
            {
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                Chipset = model.Chipset,
                MemoryType = model.MemoryType,
                CoreClock = model.CoreClock,
                BoostClock = model.BoostClock,
                SLICrossfire = model.SLICrossfire,
                FrameSync = model.FrameSync,
                Length = model.Length,
                ThermalDesignPower = model.ThermalDesignPower,
                DVIPorts = model.DVIPorts,
                HDMIPorts = model.HDMIPorts,
                MiniHDMIPorts = model.MiniHDMIPorts,
                DisplayPorts = model.DisplayPorts,
                ExpansionSlotWidth =model.ExpansionSlotWidth,
                Cooling = model.Cooling,
                IsAvailable = model.IsAvailable
            };
            _db.VideoCards.Add(entity);
            return _db.SaveChanges() == 1;
        }

        // Get All
        public IEnumerable<VideoCardListItem> GetAllVideoCards()
        {
            var VideoCardEntites = _db.VideoCards.ToList();
            var VideoCardList = VideoCardEntites.Select(m => new VideoCardListItem
            {
                Id = m.Id,
                Name = m.Name,
                Manufacturer = m.Manufacturer,
                CoreClock = m.CoreClock,
                IsAvailable = m.IsAvailable
            }).ToList();
            return VideoCardList;
        }

        // Get (Details by ID)
        public VideoCardDetail GetVideoCardById(int? vidId)
        {
            using (var _db = new ApplicationDbContext())
            {

                var VideoCardEntity =
                    _db
                    .VideoCards
                    .SingleOrDefault(e => e.Id == vidId);
                return
                    new VideoCardDetail
                    {
                        Id = VideoCardEntity.Id,
                        Name = VideoCardEntity.Name,
                        Manufacturer = VideoCardEntity.Manufacturer,
                        Chipset = VideoCardEntity.Chipset,
                        MemoryType = VideoCardEntity.MemoryType,
                        CoreClock = VideoCardEntity.CoreClock,
                        BoostClock = VideoCardEntity.BoostClock,
                        SLICrossfire = VideoCardEntity.SLICrossfire,
                        FrameSync = VideoCardEntity.FrameSync,
                        Length = VideoCardEntity.Length,
                        ThermalDesignPower = VideoCardEntity.ThermalDesignPower,
                        DVIPorts = VideoCardEntity.DVIPorts,
                        HDMIPorts = VideoCardEntity.HDMIPorts,
                        MiniHDMIPorts = VideoCardEntity.MiniHDMIPorts,
                        DisplayPorts = VideoCardEntity.DisplayPorts,
                        ExpansionSlotWidth = VideoCardEntity.ExpansionSlotWidth,
                        Cooling = VideoCardEntity.Cooling,
                        IsAvailable = VideoCardEntity.IsAvailable
                    };

            }
        }
        public bool UpdateVideoCard(VideoCardEdit model)
        {
            using (_db)
            {
                var vidEntity =
                    _db
                    .VideoCards
                    .SingleOrDefault(e => e.Id == model.Id);
                vidEntity.Name = model.Name;
                vidEntity.Manufacturer = model.Manufacturer;
                vidEntity.Chipset = model.Chipset;
                vidEntity.MemoryType = model.MemoryType;
                vidEntity.CoreClock = model.CoreClock;
                vidEntity.SLICrossfire = model.SLICrossfire;
                vidEntity.FrameSync = model.FrameSync;
                vidEntity.Length = model.Length;
                vidEntity.BoostClock = model.BoostClock;
                vidEntity.ThermalDesignPower = model.ThermalDesignPower;
                vidEntity.DVIPorts = model.DVIPorts;
                vidEntity.HDMIPorts = model.HDMIPorts;
                vidEntity.MiniHDMIPorts = model.MiniHDMIPorts;
                vidEntity.DisplayPorts = model.DisplayPorts;
                vidEntity.ExpansionSlotWidth = model.ExpansionSlotWidth;
                vidEntity.Cooling = model.Cooling;
                vidEntity.IsAvailable = model.IsAvailable;

                return _db.SaveChanges() == 1;
            }
        }

        // Delete by ID
        public bool DeleteVideoCard(int vidId)
        {
            using (_db)
            {
                var entity =
                    _db
                        .VideoCards
                        .SingleOrDefault(e => e.Id == vidId);

                _db.VideoCards.Remove(entity);

                return _db.SaveChanges() == 1;
            }
        }
    }
}
