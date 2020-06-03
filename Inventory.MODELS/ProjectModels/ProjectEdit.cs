

using Inventory.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ProjectModels
{
    public class ProjectEdit
    {
        
        public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        [Display(Name = "CPU")]
        public int? CpuId { get; set; }
        public virtual CPU CPU { get; set; }

        [Display(Name = "Memory")]
        public int? MemoryId { get; set; }
        public virtual Memory Memory { get; set; }

        [Display(Name = "Case")]
        public int? CaseId { get; set; }
        public virtual Case Case { get; set; }

        [Display(Name = "CPU Cooler")]
        public int? CoolerId { get; set; }
        public virtual CPUCooler CPUCooler { get; set; }

        [Display(Name = "Video Card")]
        public int? VideoId { get; set; }
        public virtual VideoCard VideoCard { get; set; }

        [Display(Name = "Motherboard")]
        public int? MotherboardId { get; set; }
        public virtual Motherboard Motherboard { get; set; }
        
        [Display(Name = "Power Supply")]
        public int? PsuId { get; set; }
        public virtual PowerSupplyUnit PowerSupplyUnit { get; set; }
    }
}
