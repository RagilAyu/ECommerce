using ECommerce.ViewModel;
using ECommerce.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repo
{
      public class BarangRepo
      {
            public static string Message = string.Empty;

            public static List<BarangViewModel> GetAll ()
            {
                  List<BarangViewModel> result = new List<BarangViewModel>();
                  using (var db = new ECommerceContext())
                  {
                        result = (from brg in db.Mst_Barang

                                  join kat in db.Mst_Kategori on
                                  brg.Kategori_Id equals kat.Id
                                  
                                  join var in db.Mst_Varian on
                                  brg.Id equals var.Barang_Id

                                  select new BarangViewModel
                                  {
                                        Id = brg.Id,
                                        NamaKategori = kat.Deskripsi,
                                        NamaBarang = brg.NamaBarang,
                                        VarianWarna = var.Warna,
                                        VarianUkuran = var.Ukuran,
                                        Gambar = brg.Gambar,
                                        VarianStok = var.Stok,
                                        Harga = brg.Harga,
                                        Detail = brg.Detail
                                  }).ToList();
                  }
                  return result;
            }
      }
}
