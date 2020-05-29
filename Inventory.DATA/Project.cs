using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class Project
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        
        [ForeignKey(nameof(CPU))]
        public int CpuId { get; set; }
        public virtual CPU CPU { get; set; }

        
        [ForeignKey(nameof(Memory))]
        public int MemId { get; set; }
        public virtual Memory Memory { get; set; }

        
        [ForeignKey(nameof(Case))]
        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

        
        [ForeignKey(nameof(CPUCooler))]
        public int CpuCoolId { get; set; }
        public virtual CPUCooler CPUCooler { get; set; }


        [ForeignKey(nameof(VideoCard))]
        public int VideoCardId { get; set; }
        public virtual VideoCard VideoCard { get; set; }

        
        [ForeignKey(nameof(Motherboard))]
        public int MotherboardId { get; set; }
        public virtual Motherboard Motherboard { get; set; }

        
        [ForeignKey(nameof(PowerSupplyUnit))]
        public int PSUId { get; set; }
        public virtual PowerSupplyUnit PowerSupplyUnit { get; set; }

        
        [ForeignKey(nameof(InternalStorage))]
        public int InternalId { get; set; }
        public virtual InternalStorage InternalStorage { get; set; }
    }
}
