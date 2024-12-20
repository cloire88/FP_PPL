using System;

namespace FPPPL
{
    public interface IDbServices
    {
        public void AddToDatabase()
        {
            var connection = new DatabaseConnection("jdbc:mysql://localhost:3306/mydatabase", "admin", "rahasia");
            connection.Connect();
        }
    }
}