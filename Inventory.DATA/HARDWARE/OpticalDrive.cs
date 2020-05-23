using System.ComponentModel.DataAnnotations;

namespace Inventory.DATA
{
    public class OpticalDrive
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string FormFactor { get; set; }

        [Required]
        public string Interface { get; set; }

        [Required]
        public string Capability { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int BufferCache { get; set; }
    }
}
