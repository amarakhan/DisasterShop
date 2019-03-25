using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterShop.Data
{
    public class Product
    {
        public Product()
        {
            this.ProductImages = new HashSet<ProductImage>();

        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public DisasterType DisasterType { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
