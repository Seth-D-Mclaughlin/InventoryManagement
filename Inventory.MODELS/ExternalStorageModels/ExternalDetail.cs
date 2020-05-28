using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ExternalStorageModels
{
    public class ExternalDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }

        public string Interface { get; set; }

        public int Capacity { get; set; }

        public string Type { get; set; }
        public string Color { get; set; }

        [Display(Name = "Portiable")]
        public bool IsPortiable { get; set; }
    }
}
