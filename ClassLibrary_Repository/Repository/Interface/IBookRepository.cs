using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface IBookRepository
    {
        bool searchBook(Book keyword);
        List<Book> getAllBook();
        void addBook(Book newbook);
        bool updateBook(Book newbook);
        bool deleteBook(int bookId);
        Book getDetailBook(int bookId);
    }
}
