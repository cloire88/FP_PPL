using FPPPL;
using System;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void AddToDatabase()
    {
        var connection = new DatabaseConnection("jdbc:mysql://localhost:3306/mydatabase", "admin", "rahasia");
        connection.Connect();
        connection.Query($"INSERT INTO users (name, email) VALUES ('{Name}', '{Email}')");
    }

    public void PrintUserInfo()
    {
        Console.WriteLine("Name: " + Name + "\nEmail: " + Email);

    }

}