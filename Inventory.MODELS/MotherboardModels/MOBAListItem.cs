using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.MotherboardModels
{
    public class MOBAListItem
    {
        [Required]
        public int MotherboardId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Socket { get; set; }

        [Required]
        public string FormFactor { get; set; }
        [Required]
        public int MemorySlots { get; set; }
        [Required]
        public bool IsAvailable { get; set; }

    }
}
