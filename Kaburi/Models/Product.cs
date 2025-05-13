using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaburi.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Image? Image { get; set; }
    }
}
