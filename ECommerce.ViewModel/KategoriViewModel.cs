using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ViewModel
{
      public class KategoriViewModel
      {
            public int Id { get; set; }

            [MaxLength(10), Required]
            public string Kode { get; set; }

            [MaxLength(50)]
            public string Deskripsi { get; set; }
      }
}
