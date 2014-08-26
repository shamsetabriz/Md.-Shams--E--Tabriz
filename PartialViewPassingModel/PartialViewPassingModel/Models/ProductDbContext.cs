using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PartialViewPassingModel.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext()
            : base("ProductDbContext")
        {
            
        }
        public DbSet<Product> products { set; get; }

    }
}