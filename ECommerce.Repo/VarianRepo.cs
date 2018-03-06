using ECommerce.DataModel;
using ECommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repo
{
      public class VarianRepo
      {
            public static string Message = string.Empty;
            public static List<VarianViewModel> GetAll()
            {
                  List<VarianViewModel> result = new List<VarianViewModel>();
                  using (var db = new ECommerceContext())
                  {
                        result = (from var in db.Mst_Varian

                                  select new VarianViewModel
                                  {
                                        Id = var.Id,
                                        Ukuran = var.Ukuran

                                  }).ToList();
                  }
                  return result;
            }

            public static VarianViewModel GetByItemId(int itemId)
            {
                  VarianViewModel result = new VarianViewModel();
                  using (var db = new ECommerceContext())
                  {
                        result = (from var in db.Mst_Varian 

                                  where var.Id == itemId
                                  select new VarianViewModel
                                  {
                                        Id = var.Id,
                                        Ukuran = var.Ukuran

                                  }).FirstOrDefault();
                  }
                  return result;
            }

            public static bool Update(VarianViewModel entity)
            {
                  bool result = true;
                  try
                  {
                        using (var db = new ECommerceContext())
                        {
                              if (entity.Id == 0)
                              {
                                    Varian var = new Varian();
                                    var.Id = entity.Id;
                                    var.Ukuran = entity.Ukuran;

                                    db.Mst_Varian.Add(var);
                                    db.SaveChanges();
                              }
                              else
                              {
                                    Varian var = db.Mst_Varian.Where(o => o.Id == entity.Id).FirstOrDefault();
                                    if (var != null)
                                    {
                                          var.Id = entity.Id;
                                          var.Ukuran = entity.Ukuran;

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
                              Varian varian = db.Mst_Varian.Where(o => o.Id == id).FirstOrDefault();
                              db.Mst_Varian.Remove(varian);
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

