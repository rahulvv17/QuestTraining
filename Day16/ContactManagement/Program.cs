using System;
using System.Data.SqlClient;

namespace ContactManagement
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class ContactManager
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rahul vv\Documents\ContactsDB.mdf;Integrated Security=True;";
        public void CreateContactsTable()
        {
            var createTableQuery = @"CREATE TABLE Contacts
                                    (
                                        Id INT PRIMARY KEY IDENTITY,
                                        Name VARCHAR(50),
                                        Phone VARCHAR(20)
                                    )";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var command = new SqlCommand(createTableQuery, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("Table 'Contacts' created successfully.");
            }
        }
        public void AddNewContact(string name, string phone)
        {
            var insertQuery = "INSERT INTO Contacts(Name, Phone) VALUES (@name, @phone)";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var command = new SqlCommand(insertQuery, conn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.ExecuteNonQuery();
                Console.WriteLine($"Contact '{name}' added successfully.");
            }
        }
        public void SearchContactByName(string name)
        {
            var searchQuery = "SELECT Id, Name, Phone FROM Contacts WHERE Name LIKE @name";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var command = new SqlCommand(searchQuery, conn);
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var contactName = reader.GetString(1);
                    var phone = reader.GetString(2);
                    Console.WriteLine($"ID: {id}, Name: {contactName}, Phone: {phone}");
                }
            }
        }
        public void UpdateContactById(int id, string newName, string newPhone)
        {
            var updateQuery = "UPDATE Contacts SET Name = @newName, Phone = @newPhone WHERE Id = @id";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var command = new SqlCommand(updateQuery, conn);
                command.Parameters.AddWithValue("@newName", newName);
                command.Parameters.AddWithValue("@newPhone", newPhone);
                command.Parameters.AddWithValue("@id", id);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Contact with ID {id} updated successfully.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
        }
        public void DeleteContactByPhone(string phone)
        {
            var deleteQuery = "DELETE FROM Contacts WHERE Phone = @phone";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var command = new SqlCommand(deleteQuery, conn);
                command.Parameters.AddWithValue("@phone", phone);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Contact with Phone '{phone}' deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContactManager manager = new ContactManager();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Search Contact by Name");
                Console.WriteLine("3. Update Contact by ID");
                Console.WriteLine("4. Delete Contact by Phone");
                Console.WriteLine("5. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Phone: ");
                        string phone = Console.ReadLine();
                        manager.AddNewContact(name, phone);
                        break;
                    case "2":
                        Console.Write("Enter Name to search: ");
                        string searchName = Console.ReadLine();
                        manager.SearchContactByName(searchName);
                        break;
                    case "3":
                        Console.Write("Enter Contact ID to update: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Phone: ");
                        string newPhone = Console.ReadLine();
                        manager.UpdateContactById(id, newName, newPhone);
                        break;
                    case "4":
                        Console.Write("Enter Phone to delete: ");
                        string deletePhone = Console.ReadLine();
                        manager.DeleteContactByPhone(deletePhone);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
