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
            
            [MaxLength(5), Required]
            public string Ukuran { get; set; }

            [Display(Name="Deskripsi Ukuran")]
            public string Deskripsi
            {
                  get
                  {
                        if (Ukuran == "S")
                        {
                              return "Slim";
                        }
                        else if (Ukuran == "M")
                        {
                              return "Medium";
                        }
                        else if (Ukuran == "L")
                        {
                              return "Large";
                        }
                        else if (Ukuran == "X")
                        {
                              return "Ekstra";
                        }
                        else
                        {
                              return "Lainnya";
                        }
                  }
            }


      }
}
