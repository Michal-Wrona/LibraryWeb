using LibraryWeb.Core.Books.Authors;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.Books
{
    public interface IBookRepository
    {
        void AddBook(string authorSurname, string bookName);

        Book GetBook(string name);

        IEnumerable<Book> GetBooks();

        void DeleteBook(Book book);
    }
}
