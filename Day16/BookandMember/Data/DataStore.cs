using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookandMember.Entities;

namespace BookandMember.Data
{
    internal class DataStore
    {
        public static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Name = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
            new Book { Id = 2, Name = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 3, Name = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
        };

        public static List<Member> Members = new List<Member>
        {
            new Member { Id = 1, Name = "John Doe", Email = "john@example.com" },
            new Member { Id = 2, Name = "Jane Smith", Email = "jane@example.com" },
            new Member { Id = 3, Name = "Jim Brown", Email = "jim@example.com" },
        };
    }
}
