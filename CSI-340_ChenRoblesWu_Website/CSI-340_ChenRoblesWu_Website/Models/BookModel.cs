using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class BookModel
    {
        public string Id { get; set; }

        public string BookId { get; set; }
        public string Title { get; set; }
        public string PublisherId { get; set; }
        public string NumPages { get; set; }
        public string LanguageId { get; set; }
        public string isbn13 { get; set; }
        public string Description { get; set; }

        public string PublicationDate { get; set; }

    }
}


