using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class CPUCooler
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
        public decimal Height { get; set; }
        
        [Required]
        public string Bearing { get; set; }

        [Required]
        public string Socket { get; set; }

        [Required]
        public bool WaterCooled { get; set; }

        [Required]
        public bool Fanless { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

    }
}
