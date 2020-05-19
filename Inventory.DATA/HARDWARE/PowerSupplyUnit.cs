using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public enum ModularType { full =1, semi, no}
    public class PowerSupplyUnit
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string EffeciencyRating { get; set; }

        [Required]
        public ModularType TypeOfModular { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool Fanless { get; set; }

        [Required]
        public string ATXConnectors { get; set; }
    }
}
