using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.MemeoryModels
{
    public class MemoryListItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Speed { get; set; }

        [Required]
        [Display(Name = "In use")]
        public bool IsAvailable { get; set; }
    }
}
