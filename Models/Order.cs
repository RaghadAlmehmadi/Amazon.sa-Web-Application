using System;
using System.Collections.Generic;

namespace Amazon.Models
{
    public class Order
    {
        public int OrderID { get; set; }  
        public DateTime OrderDate { get; set; } = DateTime.Now; 
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>(); 

        public Order()
        {
        }

        public Order(int orderID)
        {
            OrderID = orderID;
            OrderDate = DateTime.Now;
        }
        public Product? Product { get; set; } 
    }
    
}
