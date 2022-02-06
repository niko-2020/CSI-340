using CSI_340_ChenRoblesWu_Website.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Data
{
    public class BookContext :DbContext
    {

        public DbSet<BookModel> BookModel { get; set; }
        public DbSet<PriceModel> PriceModel { get; set; }
    }
}
