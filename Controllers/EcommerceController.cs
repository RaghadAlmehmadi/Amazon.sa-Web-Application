using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Amazon.Controllers
{
    public class EcommerceController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 5 },
            new Product { ProductID = 2, Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 10 }
        };

        private static List<Order> orders = new List<Order>();

        // Index action to display products
        public IActionResult Index()
        {
            return View("ProductList", products);  // Display product list
        }

        // Action to place an order for a selected product
        public IActionResult PlaceOrder(int productId)
        {
            Product product = products.FirstOrDefault(p => p.ProductID == productId);

            if (product == null)
            {
                return NotFound("Product not found.");
            }

            // Set a default quantity for simplicity
            int quantity = 1;

            // Check stock availability
            if (product.StockQuantity < quantity)
            {
                return BadRequest("Not enough stock available.");
            }

            // Create new order
            Order order = new Order
            {
                OrderID = orders.Count + 1,
                OrderDate = DateTime.Now
            };

            // Create order details for the product
            OrderDetails orderDetails = new OrderDetails
            {
                OrderDetailID = orders.Count + 1,
                OrderID = order.OrderID,
                Product = product,
                Quantity = quantity
            };

            order.OrderDetails.Add(orderDetails);
            orders.Add(order);

            // Redirect to OrderHistory to view the placed order
            return RedirectToAction("OrderHistory");
        }

        // Action to display order history
        public IActionResult OrderHistory(int? orderId)
        {
            if (orderId.HasValue)
            {
                // Find the order by orderId
                var order = orders.FirstOrDefault(o => o.OrderID == orderId.Value);
                if (order != null)
                {
                    // Pass order details to the view if orderId is provided
                    ViewData["OrderDetails"] = order.OrderDetails;
                    ViewData["OrderID"] = order.OrderID;
                }
            }
            return View(orders);  // Show list of orders
        }
    }
}
