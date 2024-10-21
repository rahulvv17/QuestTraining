using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Entities;

namespace BookManagement.Service
{
    internal interface IStorageServices
    {
        void Save(Book book);

        Book Search(string title);

        Book GetById(int id);

        void Delete(int id);
    }
}
