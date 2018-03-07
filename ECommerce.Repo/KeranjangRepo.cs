using ECommerce.DataModel;
using ECommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repo
{
      public class KeranjangRepo
      {
            public static string Message = string.Empty;
            public static Keranjang GetByItemId(int itemId)
            {
                  Keranjang result = new Keranjang();
                  using (var db = new ECommerceContext())
                  {
                        result = (from it in db.Mst_Barang
                                  join var in db.Mst_Varian on
                                  it.Varian_Id equals var.Id

                                  where it.Id == itemId
                                  select new Keranjang
                                  {
                                        Barang_Id = it.Id,
                                        NamaBarang = it.NamaBarang,
                                        Ukuran = var.Ukuran,
                                        StokBarang = it.Stok,
                                        HargaSatuan = it.Harga
                                  }).FirstOrDefault();
                  }
                  return result;
            }

            public static ReturnValue SaveSelling(BarangViewModel entity)
            {
                  ReturnValue result = new ReturnValue();
                  result.Success = true;

                  try
                  {
                        using (var db = new ECommerceContext())
                        {
                              if (entity.Id == 0)
                              {
                                    Keranjang ker = new Keranjang();
                                    ker.Barang_Id = entity.Id;
                                    ker.NamaBarang = entity.NamaBarang;
                                    ker.StokBarang = entity.Stok;
                                    ker.HargaSatuan = entity.Harga;

                                    db.Trx_Keranjang.Add(ker);
                                    db.SaveChanges();
                              }
                              else
                              {
                                    Keranjang ker = db.Trx_Keranjang.Where(o => o.Id == entity.Id).FirstOrDefault();
                                    if (ker != null)
                                    {
                                          ker.Barang_Id = entity.Id;
                                          ker.NamaBarang = entity.NamaBarang;
                                          ker.StokBarang = entity.Stok;
                                          ker.HargaSatuan = entity.Harga;

                                          db.SaveChanges();
                                    }
                              }

                        }
                  }
                  catch (Exception ex)
                  {
                        result.Message = ex.Message;
                        result.Success = false;
                  }
                  return result;
            }

      }
}
