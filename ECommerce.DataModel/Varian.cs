using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataModel
{
      [Table("MstVarian")]
      public class Varian
      {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            
            [Column(TypeName = "varchar"), MaxLength(5), Required]
            public string Ukuran { get; set; }

      }
}
