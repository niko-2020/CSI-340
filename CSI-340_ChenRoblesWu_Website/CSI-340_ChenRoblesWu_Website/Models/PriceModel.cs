using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class PriceModel
    {
        public int Id { get; set; }
        public float Price { get; set; }

        public int PriceId { get; set; }

        public ICollection<InventoryModel> Inventory { get; set; }

    }
}
