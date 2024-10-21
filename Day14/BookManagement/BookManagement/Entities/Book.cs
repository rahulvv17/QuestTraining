using BookManagement.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Entities
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public BookType BookType { get; set; }  // Updated based on the screenshot
        public int Price { get; set; }

        // Override ToString() to return a formatted string representation of the Book object
        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Description: {Description}, Author: {Author}";
        }
    }
}
