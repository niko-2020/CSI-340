using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class BookModel
    {
        [Key]
        public int Book_id { get; set; }
        public string Title { get; set; }
        public int Publisher_id { get; set; }
        public int Num_pages { get; set; }
        public int Language_id { get; set; }
        public string isbn13 { get; set; }

        public DateTime Publication_date { get; set; }

    }
}


