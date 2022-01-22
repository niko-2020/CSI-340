using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public string Description { get; set; }

        public ICollection<InventoryModel> Inventory { get; set; }
    }
}
