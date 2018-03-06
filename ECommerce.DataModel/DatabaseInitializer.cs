using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.DataModel
{
      public class DatabaseInitializer :
            DropCreateDatabaseIfModelChanges<ECommerceContext>
      {
            public override void InitializeDatabase(ECommerceContext context)
            {
                  base.InitializeDatabase(context);
            }

            protected override void Seed(ECommerceContext context)
            {
                  //Barang
                  context.Mst_Barang.Add(new Barang() { Kode = "BL", NamaBarang = "Blouse", Varian_Id = 1, Stok = 4, Detail = "Bahan Spandex", Harga = 65000 });
                  context.Mst_Barang.Add(new Barang() { Kode = "BL", NamaBarang = "Blouse", Varian_Id = 2, Stok = 8, Detail = "Bahan Spandex", Harga = 65000 });
                  context.Mst_Barang.Add(new Barang() { Kode = "BL", NamaBarang = "Blouse", Varian_Id = 3, Stok = 3, Detail = "Bahan Spandex", Harga = 65000 });

                  context.Mst_Barang.Add(new Barang() { Kode = "ROK", NamaBarang = "Rok Strip", Varian_Id = 1, Stok = 7, Detail = "Bahan Katun", Harga = 150000 });
                  context.Mst_Barang.Add(new Barang() { Kode = "ROK", NamaBarang = "Rok Strip", Varian_Id = 2, Stok = 10, Detail = "Bahan Katun", Harga = 150000 });
                  context.Mst_Barang.Add(new Barang() { Kode = "ROK", NamaBarang = "Rok Strip", Varian_Id = 3, Stok = 11, Detail = "Bahan Katun", Harga = 150000 });

                  context.SaveChanges();

                  //Varian
                  context.Mst_Varian.Add(new Varian() { Ukuran = "S"});
                  context.Mst_Varian.Add(new Varian() { Ukuran = "M"});
                  context.Mst_Varian.Add(new Varian() { Ukuran = "L"});

                  context.SaveChanges();

                  base.Seed(context);
            }
      }
}
