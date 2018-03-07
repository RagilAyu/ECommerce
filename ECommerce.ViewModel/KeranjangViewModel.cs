using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ViewModel
{
      public class KeranjangViewModel
      {
            public int Id { get; set; }

            public int Barang_Id { get; set; }

            public string NamaBarang { get; set; }

            public decimal StokBarang { get; set; }

            public string Ukuran { get; set; }

            public decimal HargaSatuan { get; set; }

            public decimal Kuantitas { get; set; }

            public decimal TotalHarga { get; set; }
      }
}
