using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Know_Your_Nation_Speedy.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOrdered { get; set; }
        public string TrackingNumber { get; set; }
        public string AddressToDeliever { get; set; }
        public User user { get; set; }
        public ICollection<ProductOrders> productOrders { get; set; }
    }
}