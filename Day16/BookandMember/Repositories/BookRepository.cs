using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookandMember.Data;
using BookandMember.Entities;

namespace BookandMember.Repositories
{
    internal class BookRepository
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }

        // Get a book by ID
        public GenericResponse<Book> GetBookById(int id)
        {
            var book = DataStore.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = book,
            };
        }

        // Get a book by name
        public GenericResponse<Book> GetBookByName(string name)
        {
            var book = DataStore.Books.FirstOrDefault(x => x.Name == name);
            if (book == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = book,
            };
        }
    }
}
