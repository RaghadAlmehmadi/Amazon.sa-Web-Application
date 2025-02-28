namespace Amazon.Models
{
    public class Product
    {
        public int ProductID { get; set; }  
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        private static List<Product> products = new List<Product>
{
    new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 5 },
    new Product { ProductID = 2, Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 10 }
};

    }
    
}

