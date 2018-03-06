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

            public static List<BarangViewModel> GetAll()
            {
                  List<BarangViewModel> result = new List<BarangViewModel>();
                  using (var db = new ECommerceContext())
                  {
                        result = (from brg in db.Mst_Barang
                                  join var in db.Mst_Varian on
                                  brg.Varian_Id equals var.Id

                                  select new BarangViewModel
                                  {
                                        Id = brg.Id,
                                        Kode = brg.Kode,
                                        NamaBarang = brg.NamaBarang,
                                        Varian_Id = var.Id,
                                        VarianUkuran = var.Ukuran,
                                        PathGambar = brg.PathGambar,
                                        Harga = brg.Harga,
                                        Detail = brg.Detail,
                                        Stok = brg.Stok
                                  }).ToList();
                  }
                  return result;
            }
            public static BarangViewModel GetByItemId(int itemId)
            {
                  BarangViewModel result = new BarangViewModel();
                  using (var db = new ECommerceContext())
                  {
                        result = (from brg in db.Mst_Barang
                                  join var in db.Mst_Varian on
                                  brg.Varian_Id equals var.Id

                                  where brg.Id == itemId
                                  select new BarangViewModel
                                  {
                                        Id = brg.Id,
                                        Kode = brg.Kode,
                                        NamaBarang = brg.NamaBarang,
                                        Varian_Id = var.Id,
                                        VarianUkuran = var.Ukuran,
                                        PathGambar = brg.PathGambar,
                                        Harga = brg.Harga,
                                        Detail = brg.Detail,
                                        Stok = brg.Stok
                                  }).FirstOrDefault();
                  }
                  return result;
            }

            public static bool Update(BarangViewModel entity)
            {
                  bool result = true;
                  try
                  {
                        using (var db = new ECommerceContext())
                        {
                              if (entity.Id == 0)
                              {
                                    Barang brg = new Barang();
                                    brg.Id = entity.Id;
                                    brg.Kode = entity.Kode;
                                    brg.NamaBarang = entity.NamaBarang;
                                    brg.Varian_Id = entity.Varian_Id;
                                    brg.PathGambar = entity.PathGambar;
                                    brg.Harga = entity.Harga;
                                    brg.Detail = entity.Detail;
                                    brg.Stok = entity.Stok;

                                    db.Mst_Barang.Add(brg);
                                    db.SaveChanges();
                              }
                              else
                              {
                                    Barang brg = db.Mst_Barang.Where(o => o.Id == entity.Id).FirstOrDefault();
                                    if (brg != null)
                                    {
                                          brg.Id = entity.Id;
                                          brg.Kode = entity.Kode;
                                          brg.NamaBarang = entity.NamaBarang;
                                          brg.Varian_Id = entity.Varian_Id;
                                          brg.PathGambar = entity.PathGambar;
                                          brg.Harga = entity.Harga;
                                          brg.Detail = entity.Detail;
                                          brg.Stok = entity.Stok;

                                          db.SaveChanges();
                                    }
                              }
                        }
                  }
                  catch (Exception ex)
                  {
                        Message = ex.Message;
                        result = false;
                  }
                  return result;
            }

            public static bool DeleteById(int id)
            {
                  bool result = true;
                  try
                  {
                        using (var db = new ECommerceContext())
                        {
                              Barang barang = db.Mst_Barang.Where(o => o.Id == id).FirstOrDefault();
                              db.Mst_Barang.Remove(barang);
                              db.SaveChanges();
                        }
                  }
                  catch (Exception ex)
                  {
                        result = false;
                        Message = ex.Message;
                  }
                  return result;
            }
      }
}
