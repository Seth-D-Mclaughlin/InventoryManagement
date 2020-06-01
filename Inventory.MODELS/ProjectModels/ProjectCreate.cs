﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.ProjectModels
{
    public class ProjectCreate
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }


        public int CpuId { get; set; }
        public string CpuName { get; set; }
        public int MemId { get; set; }
        public int CaseId { get; set; }
        public int CpuCoolId { get; set; }
        public int VideoCardId { get; set; }
        public int MotherboardId { get; set; }
        public int PSUId { get; set; }
        public int InternalId { get; set; }
    }
}