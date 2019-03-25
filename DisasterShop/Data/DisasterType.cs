using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DisasterShop.Data
{
    public class DisasterType
    {
        public DisasterType()
        {
            this.Products = new HashSet<Product>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BannerImageUrl { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
