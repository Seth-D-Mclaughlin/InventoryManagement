﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.CPUCoolerModels
{
    public class CPUCoolerListItem
    {
        public int CoolerId { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        [Display(Name = "Cooler Color")]
        public string Color { get; set; }
        public string Socket { get; set; }

        [Display(Name = "Water Cooled")]
        public bool WaterCooled { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
