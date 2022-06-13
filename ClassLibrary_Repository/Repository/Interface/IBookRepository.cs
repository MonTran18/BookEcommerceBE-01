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
        List<Book> getAllBook();
        void AddBook(Book newbook);
        bool UpdateBook(Book newbook);
        bool DeleteBook(int bookId);
        Book getDetailBook(int bookId);
    }
}
