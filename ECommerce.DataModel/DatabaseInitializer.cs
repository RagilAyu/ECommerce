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
                  //Kategori
                  context.Mst_Kategori.Add(new Kategori() { Kode = "AT", Deskripsi = "Atasan" });
                  context.Mst_Kategori.Add(new Kategori() { Kode = "BW", Deskripsi = "Bawahan" });

                  context.SaveChanges();

                  //Barang
                  context.Mst_Barang.Add(new Barang() { Kode = "BL", Kategori_Id = 1, NamaBarang = "Blouse", Gambar = Image.FromFile(@"qoregra-flowery-blouse.jpg"), Detail = "Bahan Spandex", Harga = 65000 });
                  context.Mst_Barang.Add(new Barang() { Kode = "ROK", Kategori_Id = 2, NamaBarang = "Rok", Detail = "Bahan Katun", Harga = 150000});

                  context.SaveChanges();

                  //Varian
                  context.Mst_Varian.Add(new Varian() { Barang_Id = 1, Ukuran = "S", Warna = "Hitam" , Stok = 2});
                  context.Mst_Varian.Add(new Varian() { Barang_Id = 2, Ukuran = "M", Warna = "Hitam" , Stok = 3});
                  context.Mst_Varian.Add(new Varian() { Barang_Id = 2, Ukuran = "S", Warna = "Hitam" , Stok = 1});

                  context.SaveChanges();

                  base.Seed(context);
            }
      }
}
