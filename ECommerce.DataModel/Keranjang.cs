using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataModel
{
      [Table("TrxKeranjang")]
      public class Keranjang
      {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int Barang_Id { get; set; }

            public string NamaBarang { get; set; }

            public string Ukuran { get; set; }
            
            [Column(TypeName="decimal"), Required]
            public decimal Kuantitas { get; set; }

            public decimal HargaSatuan { get; set; }
            
            [Column(TypeName="decimal"), Required]
            public decimal TotalHarga { get; set; }

            [ForeignKey("Barang_Id")]
            public virtual Barang Barang { get; set; }
      }
}
