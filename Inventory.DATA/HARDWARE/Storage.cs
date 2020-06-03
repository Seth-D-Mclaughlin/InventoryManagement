using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.DATA
{
    public class Storage
    {
        [Key]
        [Required]
        public int StorageId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public string Interface { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Type { get; set; }

        //public int? ProjectId { get; set; }
        //[ForeignKey(nameof(ProjectId))]
        //public virtual Project Project { get; set; }
    }
}
