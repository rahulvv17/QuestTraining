using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInsert
{
    internal class Program
    {
        const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rahul vv\Documents\QuestDB.mdf; Integrated Security = True;";

        static void Main(string[] args)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Author: ");
            var author = Console.ReadLine();

            Console.Write("Price: ");
            var price = Console.ReadLine();

            var insertQuery = $"INSERT INTO Books(name, author, price) VALUES (@name, @author, @price)";
            var conn = new SqlConnection(connStr);

            conn.Open();
            var command = new SqlCommand(insertQuery, conn); command.Parameters.AddWithValue("@name", name); command.Parameters.AddWithValue("@author", author); command.Parameters.AddWithValue("@price", price);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
