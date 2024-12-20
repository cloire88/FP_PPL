using FPPPL;
using System;

public class Product : IDbServices
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }

    public Product(string productName, int? quantity)
    {
        ProductName = productName;
        Quantity = quantity ?? 0;
    }

    public void AddToDatabase()
    {
        var connection = new DatabaseConnection("jdbc:mysql://localhost:3306/mydatabase", "admin", "rahasia");
        connection.Connect();
        connection.Query($"INSERT INTO products (name, quantity) VALUES ('{ProductName}', {Quantity})");
    }

    public void PrintProductInfo()
    {
        Console.WriteLine("Product name: " + ProductName + "\nProduct Quantity: " + Quantity);

    }
}