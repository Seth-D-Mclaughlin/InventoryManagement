using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ExternalStorageModels
{
    public class ExternalCreate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }

        [Required]
        public string Interface { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Type { get; set; }
        public string Color { get; set; }
        [Display(Name = "Portable?")]
        public bool IsPortiable { get; set; }
    }
}
