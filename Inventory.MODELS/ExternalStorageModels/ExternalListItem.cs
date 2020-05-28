using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ExternalStorageModels
{
    public class ExternalListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Interface { get; set; }
        public int Capacity { get; set; }
        public bool IsPortiable { get; set; }
        public bool IsAvailable { get; set; }

    }
}
