using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.InternalStorageModels
{
    public class InternalDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }

        public string Interface { get; set; }

        public int Capacity { get; set; }

        public string Type { get; set; }
        
        [Display(Name="Form Factor")]
        public string FormFactor { get; set; }
        public bool NVME { get; set; }
    }
}
