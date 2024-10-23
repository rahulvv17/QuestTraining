using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rahul vv\Documents\QuestDB.mdf; Integrated Security = True;";
            var createTableQuery = @"CREATE TABLE BOOKS
                                    (
                                        id INT PRIMARY KEY IDENTITY,
                                        name VARCHAR(50),
                                        author VARCHAR(50),
                                        price INT DEFAULT 0
                                    )";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();

            //using (var conn2 = new SqlConnection(connStr))
            //{
            //    conn2.Open();
            //    var insertQuery1 = @"INSERT INTO BOOKS(name, author, price) VALUES('Book 1', 'Mr X', 500)";

            //    var command1 = new SqlCommand(insertQuery1, conn2);
            //    command1.ExecuteNonQuery();
            //}
        }
    }
}
