using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.DataModel
{
      [Table("MstBarang")]
      public class Barang
      {
            [Key, DatabaseGenerated (DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Column(TypeName="varchar"), MaxLength(10), Required]
            public string Kode { get; set; }

            public int Kategori_Id { get; set; }

            [Column(TypeName="varchar"), MaxLength(50), Required]
            public string NamaBarang { get; set; }
                       
            [Column(TypeName = "varchar"), MaxLength(100), Required]
            public string Detail { get; set; }
            
            [Column(TypeName = "decimal"), Required]
            public decimal Harga { get; set; }

            [ForeignKey("Kategori_Id")]
            public virtual Kategori Kategori { get; set; }

            public virtual ICollection<Varian> Varians { get; set; }
      }
}
