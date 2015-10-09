using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcZooStore.Models
{
    public class ZooStoreEntities:DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
       public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}