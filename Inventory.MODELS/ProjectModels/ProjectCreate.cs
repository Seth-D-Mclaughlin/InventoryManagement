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

        public int CpuId { get; set; }
        public virtual CPU CPU { get; set; }

        public int MemoryId { get; set; }
        public virtual Memory Memory { get; set; }

        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

        public int CoolerId { get; set; }
        public virtual CPUCooler CPUCooler { get; set; }

        public int VideoId { get; set; }
        public virtual VideoCard VideoCard { get; set; }

        public int MotherboardId { get; set; }
        public virtual Motherboard Motherboard { get; set; }

        public int PsuId { get; set; }
        public virtual PowerSupplyUnit PowerSupplyUnit { get; set; }

    }
}
