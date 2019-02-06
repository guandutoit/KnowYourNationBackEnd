using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Know_Your_Nation_Speedy.Models
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public string CoverImageLocation { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }//Know your nation or Speedy
        public int QuantityOnHand { get; set; }
        public ICollection<ProductOrders> ProductOrder { get; set; }
    }
}
