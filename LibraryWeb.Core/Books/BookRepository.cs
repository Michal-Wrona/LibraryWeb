using LibraryWeb.Core.Books.Authors;
using LibraryWeb.Core.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryWeb.Core.Books
{
    public class BookRepository : IBookRepository

    {
        private readonly LibraryWebDbContext _dbContext;
        public BookRepository (LibraryWebDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(string authorSurname,string bookName)
        {
            var author = _dbContext.Authors.SingleOrDefault(x => x.Surname == authorSurname);
            var book = new Book { Name = bookName, Author = author, AuthorId=author.Id };

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();


        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }
    }
}
