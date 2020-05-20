using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.CPUCoolerModels
{
    public class CPUCoolerCreate
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public decimal Height { get; set; }

        [Required]
        public string Bearing { get; set; }

        [Required]
        public string Socket { get; set; }

        [Required]
        [Display(Name="Water Cooled")]
        public bool WaterCooled { get; set; }

        [Required]
        public bool Fanless { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
