using Amazon.Models;

public class OrderDetails
{
    public int OrderDetailID { get; set; }
    public int OrderID { get; set; } 
    public Product Product { get; set; } = null!;  // Ensuring it's always assigned
    public int Quantity { get; set; }
    public double SubTotal => Quantity * Product.Price; // Calculated property (no need to manually assign)

    // Parameterless Constructor (Required for Model Binding)
    public OrderDetails() { }

    // Parameterized Constructor
    public OrderDetails(int orderDetailID, int orderID, Product product, int quantity)
    {
        OrderDetailID = orderDetailID;
        OrderID = orderID;
        Product = product ?? throw new ArgumentNullException(nameof(product));  // Avoid null reference issues
        Quantity = quantity;
    }
}
