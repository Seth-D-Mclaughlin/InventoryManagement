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
        [Key]
        public int ProjectId { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }





        public int? MemoryId { get; set; }
        [ForeignKey("MemoryId")]
        public virtual Memory Memory { get; set; }


        public int? CaseId { get; set; }
        [ForeignKey("CaseId")]
        public virtual Case Case { get; set; }


        public int? CoolerId { get; set; }
        [ForeignKey("CoolerId")]
        public virtual CPUCooler CPUCooler { get; set; }
        
        public int? CpuId { get; set; }
        [ForeignKey("CpuId")]
        public virtual CPU CPU { get; set; }


        public int? VideoId { get; set; }
        [ForeignKey("VideoId")]
        public virtual VideoCard VideoCard { get; set; }


        public int? MotherboardId { get; set; }
        [ForeignKey("MotherboardId")]
        public virtual Motherboard Motherboard { get; set; }


        public int? PsuId { get; set; }
        [ForeignKey("PsuId")]
        public virtual PowerSupplyUnit PowerSupplyUnit { get; set; }

    }
}
