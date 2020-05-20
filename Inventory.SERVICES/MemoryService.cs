using Inventory.DATA;
using Inventory.MODELS.MemeoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.SERVICES
{
    public class MemoryService
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();


        //Create
        //public bool CreateMemory(MemoryCreate model)
        //{
        //    Memory memory = new Memory
        //    {
        //        Name = model.Name
        //    };
        //}
    }
}
