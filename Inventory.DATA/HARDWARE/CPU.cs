using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class CPU
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Manufacturer { get; set; }
        
        [Required]
        public int CoreCount { get; set; }
        
        [Required]
        public float CoreClock { get; set; }
        
        [Required]
        public string Series { get; set; }
        
        [Required]
        public string MicroArchitecture { get; set; }
        
        [Required]
        public string CoreFamily { get; set; }
        
        [Required]
        public string Socket { get; set; }
        
        [Required]
        public bool IntegratedGraphics { get; set; }
        
        [Required]
        public bool SimultaneousMultithreading { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

    }
}
