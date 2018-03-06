using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ECommerce.DataModel
{
      [Table("MstBarang")]
      public class Barang
      {
            [Key, DatabaseGenerated (DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int Varian_Id { get; set; }

            [Column(TypeName="varchar"), MaxLength(1000)]
            public string PathGambar { get; set; }

            [Column(TypeName="varchar"), MaxLength(10), Required]
            public string Kode { get; set; }

            [Column(TypeName="varchar"), MaxLength(50), Required]
            public string NamaBarang { get; set; }
                       
            [Column(TypeName = "varchar"), MaxLength(100), Required]
            public string Detail { get; set; }
            
            [Column(TypeName = "decimal"), Required]
            public decimal Harga { get; set; }

            [Column(TypeName = "decimal")]
            public decimal Stok { get; set; }

            //public virtual ICollection<Keranjang> Keranjangs { get; set; }

            //public virtual ICollection<Ulasan> Ulasan { get; set; }
            //public virtual ICollection<DaftarKeinginan> DaftarKeinginan { get; set; }
            //public virtual ICollection<Keranjang> Keranjang { get; set; }
            //public virtual ICollection<Pembelian> Pembelian { get; set; }
      }
}
