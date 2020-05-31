using System;
using System.Collections.Generic;

namespace Pahally.Models
{
    public class Order
    {
        /// <summary>
        /// Complete information on all orders made
        /// </summary>
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}