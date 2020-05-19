using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class ExternalStorage : Storage
    {
        public string Color { get; set; }
        public bool IsPortiable { get; set; }
    }
}
