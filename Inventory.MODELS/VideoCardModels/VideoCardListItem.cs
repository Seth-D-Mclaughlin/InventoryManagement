using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.VideoCardModels
{
    public class VideoCardListItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }
        
        [Required]
        [Display(Name = "Core Clock Speed")]
        public int CoreClock { get; set; }
        
        [Required]
        [Display(Name = "In use")]
        public bool IsAvailable { get; set; }

    }
}
