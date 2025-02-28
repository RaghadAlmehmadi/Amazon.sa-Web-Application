Ecommerce Application
This is a simple e-commerce application built using ASP.NET Core MVC. It allows users to browse products, place orders, and view their order history.

Features
Product List: Displays a list of products with their name, category, price, and stock quantity.
Order History: Users can view their order history with details of each order.
Order Details: Displays product details, quantity, and subtotal for each order.
Tech Stack
Backend: ASP.NET Core MVC
Frontend: HTML

Folder Structure
Controllers: Contains the EcommerceController.cs that handles the logic for displaying products, placing orders, and viewing order history.
Models: Contains classes representing the Product, Order, and OrderDetails models.
Views: Contains the .cshtml files for rendering the product list, placing orders, and displaying the order history.

EcommerceController.cs
Contains logic for displaying products, placing orders, and viewing order history.

ProductList.cshtml
View that shows the list of products and includes an "Order" button for each product.

OrderHistory.cshtml
View that displays the user's order history, with an option to view order details.

OrderDetails.cshtml
Displays the details of a specific order, such as product name, quantity, price, and subtotal.

Usage
Product List Page:
Displays available products.
Each product has an Order button.
Clicking Order will place the order and redirect to the Order History page.
Order History Page:
Displays all orders placed by the user.
Each order has a View Details button to view more information about the order.
Order Details:
Shows details such as product name, quantity, price, and subtotal.
