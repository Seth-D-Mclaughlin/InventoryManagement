using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.OpticalDriveModels
{
    public class ODEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; }

        [Required]
        public string Interface { get; set; }

        [Required]
        public string Capability { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Buffer Cache")]
        public int BufferCache { get; set; }

        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }

    }
}
