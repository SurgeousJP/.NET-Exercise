using System;

namespace ProductManagement.Models
{
    public class ProductDTO
    {
        public string ProdID { get; set; }
        public string ProdName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
