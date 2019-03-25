using System;
namespace DisasterShop.Data
{
    public class ProductImage
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string AltText { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
