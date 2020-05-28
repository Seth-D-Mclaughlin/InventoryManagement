using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.InternalStorageModels
{
    public class InternalCreate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public string Interface { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Type { get; set; }
        public string FormFactor { get; set; }
        public bool NVME { get; set; }
    }
}
