using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class InternalStorage : Storage
    {
        public string FormFactor { get; set; }
        public bool NVME { get; set; }
    }
}
