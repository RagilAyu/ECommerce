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
            //public static Keranjang GetByItemId(int itemId)
            //{
            //      Keranjang result = new Keranjang();
            //      using (var db = new ECommerceContext())
            //      {
            //            result = (from it in db.Mst_Barang
            //                      join var in db.Mst_Varian on
            //                      it.Id equals var.Barang_Id

            //                      where it.Id == itemId
            //                      select new Keranjang
            //                      {
            //                           Barang_Id  = it.Id,
            //                           NamaBarang  = it.NamaBarang,
            //                           Ukuran = var.Ukuran,
            //                           HargaSatuan = it.Harga
            //                      }).FirstOrDefault();
            //      }
            //      return result;
            //}

            //public static ReturnValue SaveSelling(KeranjangViewModel entity)
            //{
            //      ReturnValue result = new ReturnValue();
            //      result.Success = true;

            //      try
            //      {
            //            using (var db = new ECommerceContext())
            //            {
                             
            //            }
            //      }
            //      catch (Exception ex)
            //      {
            //            result.Message = ex.Message;
            //            result.Success = false;
            //      }
            //      return result;
            //}
      }
}
