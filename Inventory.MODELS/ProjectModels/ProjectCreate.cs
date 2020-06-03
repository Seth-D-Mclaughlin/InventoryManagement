using Inventory.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ProjectModels
{
    public class ProjectCreate
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        [Display(Name ="CPU")]
        public int? CpuId { get; set; }
        public CPU CPU { get; set; }

        [Display(Name = "Memory")]

        public int? MemoryId { get; set; }
        public Memory Memory { get; set; }

        [Display(Name = "Case")]
        public int? CaseId { get; set; }
        public  Case Case { get; set; }

        public int? CoolerId { get; set; }
        public  CPUCooler CPUCooler { get; set; }
        
        [Display(Name = "Video Card")]
        public int? VideoId { get; set; }
        public  VideoCard VideoCard { get; set; }

        [Display(Name = "Motherboard")]
        public int? MotherboardId { get; set; }
        public  Motherboard Motherboard { get; set; }

        [Display(Name = "Power Supply")]
        public int? PsuId { get; set; }
        public  PowerSupplyUnit PowerSupplyUnit { get; set; }

    }
}
