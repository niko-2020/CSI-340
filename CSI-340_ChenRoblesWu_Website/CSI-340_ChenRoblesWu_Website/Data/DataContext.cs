using Microsoft.EntityFrameworkCore;
using CSI_340_ChenRoblesWu_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {       
        
        }

        public DbSet<BookModel> Book { get; set; }
        //public DbSet<PriceModel> Price { get; set; }
    }
}
