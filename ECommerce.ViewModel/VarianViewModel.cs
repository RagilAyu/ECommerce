using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ViewModel
{
      public class VarianViewModel
      {
            public int Id { get; set; }

            public int Barang_Id { get; set; }

            [MaxLength(10), Required]
            public string Warna { get; set; }

            [MaxLength(5), Required]
            public string Ukuran { get; set; }

            [Required]
            public decimal Stok { get; set; }
      }
}
