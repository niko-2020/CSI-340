using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class InventoryModel
    {
        public int Id { get; set; }

        public int InventoryId { get; set; }

        public int BookId { get; set; }

        public int PriceId { get; set; }

        public PriceModel PriceModel { get; set; }

        public BookModel BookModel { get; set; }
         
    }
}
