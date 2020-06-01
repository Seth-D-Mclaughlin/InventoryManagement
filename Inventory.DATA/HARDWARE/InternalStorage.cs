using System.Collections.Generic;

namespace Inventory.DATA
{
    public class InternalStorage : Storage
    {
        public string FormFactor { get; set; }
        public bool NVME { get; set; }

    }
}
