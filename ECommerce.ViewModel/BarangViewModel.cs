using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ECommerce.ViewModel
{
      public class BarangViewModel
      {
            [Display(Name = "Id Barang")]
            public int Id { get; set; }

            [MaxLength(10), Required]
            public string Kode { get; set; }

            [MaxLength(1000)]
            public string PathGambar { get; set; }

            [Display(Name ="Nama Barang"), MaxLength(50), Required]
            public string NamaBarang { get; set; }

            [Display(Name = "Ukuran")]
            public int Varian_Id { get; set; }

            [Display(Name ="Ukuran")]
            public string VarianUkuran { get; set; }

            [Required]
            public decimal Stok { get; set; }

            [MaxLength(100), Required]
            public string Detail { get; set; }

            [Required]
            public decimal Harga { get; set; }

      }
}
