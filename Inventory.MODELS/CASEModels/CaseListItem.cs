using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.CASEModels
{
    public class CaseListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Tower Size")]
        public string Type { get; set; }
        
        [Display(Name="Case Color")]
        public string Color { get; set; }
        
        [Display(Name="Motherboard Form Factor")]
        public string MotherboardFormFactor { get; set; }
        
        [Display(Name="In use?")]
        public bool IsAvailable { get; set; }
    }
}
