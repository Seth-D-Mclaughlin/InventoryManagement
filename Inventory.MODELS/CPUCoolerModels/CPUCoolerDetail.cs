﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.CPUCoolerModels
{
    public class CPUCoolerDetail
    {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Color { get; set; }

        public decimal Height { get; set; }

        public string Bearing { get; set; }

        public string Socket { get; set; }

        [Display(Name = "Water Cooled")]
        public bool WaterCooled { get; set; }

        public bool Fanless { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
