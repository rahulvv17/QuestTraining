using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Program
    {
        // Dictionary to store product details
        static Dictionary<int, Dictionary<string, object>> products = new Dictionary<int, Dictionary<string, object>>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nINVENTORY MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateStock();
                        break;
                    case 3:
                        GetProductDetails();
                        break;
                    case 4:
                        GetLowStockProducts();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        // Function to add a new product
        //
        static void AddProduct()
        {
            Console.Write("Enter Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Product Stock: ");
            int stock = int.Parse(Console.ReadLine());

            // Add product to the dictionary
            products.Add(productId, new Dictionary<string, object>
            {
                { "Name", name },
                { "Price", price },
                { "Stock", stock }
            });

            Console.WriteLine("Product added successfully!");
        }

        // Function to update stock of a product
        static void UpdateStock()
        {
            Console.Write("Enter Product ID to update stock: ");
            int productId = int.Parse(Console.ReadLine());

            if (products.ContainsKey(productId))
            {
                Console.Write("Enter new stock quantity: ");
                int newStock = int.Parse(Console.ReadLine());
                products[productId]["Stock"] = newStock;
                Console.WriteLine("Stock updated successfully!");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        // Function to get product details by ID
        static void GetProductDetails()
        {
            Console.Write("Enter Product ID to view details: ");
            int productId = int.Parse(Console.ReadLine());

            if (products.ContainsKey(productId))
            {
                var product = products[productId];
                Console.WriteLine($"\nProduct ID: {productId}");
                Console.WriteLine($"Name: {product["Name"]}");
                Console.WriteLine($"Price: {product["Price"]}");
                Console.WriteLine($"Stock: {product["Stock"]}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        // Function to get low stock products
        static void GetLowStockProducts()
        {
            Console.Write("Enter the stock threshold: ");
            int threshold = int.Parse(Console.ReadLine());

            Console.WriteLine("\nProducts with stock below the threshold:");
            foreach (var product in products)
            {
                if ((int)product.Value["Stock"] < threshold)
                {
                    Console.WriteLine($"Product ID: {product.Key}, Name: {product.Value["Name"]}, Stock: {product.Value["Stock"]}");
                }
            }
        }
    }
}
