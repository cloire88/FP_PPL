using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPPL { 
    public class MainClass
    {
        public static void Main(string[] args)
        {
            User myUser = new User("Dahyun", "dahyun@gmail.com");
            Product myProduct = new Product("Ice Cream", 10);
            Product product = new Product("Pizza", 5);

            myUser.AddToDatabase();
            myProduct.AddToDatabase();
            product.AddToDatabase();

            myUser.PrintUserInfo();
            myProduct.PrintProductInfo();
            Console.WriteLine();
            // TODO: need to add Order to database
            Order order1 = new Order(myUser);
            order1.AddProduct(myProduct);
            order1.AddProduct(product);
            order1.PrintOrder();
        }
    }
}