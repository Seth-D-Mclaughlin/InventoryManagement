﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.CPUModels
{
    public class CPUListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        [Display(Name = "Core Count")]
        public int CoreCount { get; set; }

        
        [Display(Name = "Core Clock")]
        public float CoreClock { get; set; }

        
        [Display(Name = "Core Boost Clock")]
        public float BoostClock { get; set; }

        public string Socket { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}