using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WingtipToysV2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToysV2")
        {

        }
        
        // Use the Entity classes to create tables named: 'Categories' & 'Products'
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}