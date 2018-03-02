using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ViewModel
{
      public class BarangViewModel
      {
            public int Id { get; set; }

            [MaxLength(10), Required]
            public string Kode { get; set; }
            public byte[] Gambar { get; set; }

            public int Kategori_Id { get; set; }

            public string NamaKategori { get; set; }

            [MaxLength(50), Required]
            public string NamaBarang { get; set; }

            public string VarianWarna { get; set; }

            public string VarianUkuran { get; set; }

            public decimal VarianStok { get; set; }

            [MaxLength(100), Required]
            public string Detail { get; set; }

            [Required]
            public decimal Harga { get; set; }
      }
}
