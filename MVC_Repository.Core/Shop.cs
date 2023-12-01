using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository.Core
{
    public class Shop
    {
        public int Id { get; set; }
        [Required]
        public string Items { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Price { get; set; }


    }
}
