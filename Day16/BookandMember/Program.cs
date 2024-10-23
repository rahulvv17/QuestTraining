using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookandMember.Repositories;

namespace BookandMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookRepository = new BookRepository();
            var memberRepository = new MemberRepository();

            // List all books
            var allBooks = bookRepository.GetAllBooks();
            if (allBooks.Success)
            {
                foreach (var book in allBooks.Data)
                {
                    Console.WriteLine($"Book: {book.Name}, Author: {book.Author}, Year: {book.Year}");
                }
            }

            // Search for a book by ID
            var bookById = bookRepository.GetBookById(2);
            Console.WriteLine(bookById.Success ? $"Found Book: {bookById.Data.Name}" : bookById.Message);

            // Search for a book by name
            var bookByName = bookRepository.GetBookByName("1984");
            Console.WriteLine(bookByName.Success ? $"Found Book: {bookByName.Data.Name}" : bookByName.Message);

            // List all members
            var allMembers = memberRepository.GetAllMembers();
            if (allMembers.Success)
            {
                foreach (var member in allMembers.Data)
                {
                    Console.WriteLine($"Member: {member.Name}, Email: {member.Email}");
                }
            }

            // Search for a member by name
            var memberByName = memberRepository.GetMemberByName("John Doe");
            Console.WriteLine(memberByName.Success ? $"Found Member: {memberByName.Data.Name}" : memberByName.Message);

            // Search for a member by email
            var memberByEmail = memberRepository.GetMemberByEmail("jane@example.com");
            Console.WriteLine(memberByEmail.Success ? $"Found Member: {memberByEmail.Data.Name}" : memberByEmail.Message);
        }
    }
}
