using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.DataModel
{
      [Table("MstKategori")]
      public class Kategori
      {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Column(TypeName="varchar"), MaxLength(10), Required]
            public string Kode { get; set; }
            
            [Column(TypeName = "varchar"), MaxLength(50)]
            public string Deskripsi { get; set; }

            public int MyProperty { get; set; }

            public virtual ICollection<Barang> Barangs { get; set; }
      }
}
