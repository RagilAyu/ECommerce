using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.DataModel
{
      public class ECommerceContext : DbContext
      {
            public ECommerceContext()
            {
                  Database.SetInitializer(new DatabaseInitializer());
            }

            public DbSet<Barang> Mst_Barang { get; set; }

            public DbSet<Varian> Mst_Varian { get; set; }

            public DbSet<Keranjang> Trx_Keranjang { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                  modelBuilder.Entity<Barang>().Property(p => p.Stok).HasPrecision(18, 2);
                  modelBuilder.Entity<Barang>().Property(p => p.Harga).HasPrecision(18, 2);


                  base.OnModelCreating(modelBuilder);
            }
      }
}
