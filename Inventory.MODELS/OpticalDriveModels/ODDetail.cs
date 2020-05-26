using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.OpticalDriveModels
{
    public class ODDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string FormFactor { get; set; }

        public string Interface { get; set; }

        public string Capability { get; set; }

        public string Color { get; set; }

        public int BufferCache { get; set; }
        public bool IsAvailable { get; set; }
    }
}

