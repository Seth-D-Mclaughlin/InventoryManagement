using Inventory.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ProjectModels
{
    public class ProjectListItem
    {
        [Required]
        public string Name { get; set; }
        public string Notes { get; set; }

    }
}
