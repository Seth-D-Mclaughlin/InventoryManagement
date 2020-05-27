﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.OpticalDriveModels
{
    public class ODListItem
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]

        public string Manufacturer { get; set; }


        [Required]

        public string Interface { get; set; }
        [Required]

        public string Capability { get; set; }
        [Required]

        public string Color { get; set; }
        [Required]
        [Display(Name="In use?")]
        public bool IsAvailable { get; set; }
    }
}
