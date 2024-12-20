using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPPL
{

    public class Order
    {
        private static int _counter = 0;
        private int _id;
        private User _user;
        private LinkedList<Product> _prodlist;

        public Order(User user)
        {
            _counter++;
            _id = _counter;
            _user = user;
            _prodlist = new LinkedList<Product>();
        }

        public Product AddProduct(Product p)
        {
            _prodlist.AddLast(p);
            return p;
        }

        public void AddToDatabase()
        {
            var connection = new DatabaseConnection("jdbc:mysql://localhost:3306/mydatabase", "admin", "rahasia");
            connection.Connect();
            connection.Query($"INSERT INTO order (id) VALUES ({_id}, Quantity)");

        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order id  : " + _id);
            Console.WriteLine($"Recipient : " + _user.Name);
            Console.WriteLine("--------------------");
            foreach (Product p in _prodlist)
            {
                Console.WriteLine(p.ProductName + "   " + p.Quantity);
            }
        }

    }

}
