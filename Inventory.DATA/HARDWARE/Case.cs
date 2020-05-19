using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class Case
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string PowerSupply { get; set; }
        
        [Required]
        public string Type { get; set; }

        [Required]
        public string SidePanelWindow { get; set; }

        [Required]
        public bool PowerSupplyShroud { get; set; }

        [Required]
        public string FrontPanelUSB { get; set; }

        [Required]
        public string MotherboardFormFactor { get; set; }

        [Required]
        public int External52Bay { get; set; }
        
        [Required]
        public int External35Bay { get; set; }

        [Required]
        public int internal35Bay { get; set; }

        [Required]
        public int internal25Bay { get; set; }

        [Required]
        public int FullHeightExpansionSlots { get; set; }
        
        [Required]
        public int HalfHeightExpansionSlots { get; set; }
    }
}
