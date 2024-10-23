using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSelect
{
    internal class Program
    {
        const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rahul vv\Documents\QuestDB.mdf; Integrated Security = True;";
        static void Main(string[] args)
        {
            var insertQuery = $"SELECT id, name, author, price from Books";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command = new SqlCommand(insertQuery, conn); var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var value = reader.GetString(2);
                var price = reader.GetInt32(3);

                Console.WriteLine($"{id} {name} {value} {price}");
            }
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
