using LibraryWeb.Core.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryWeb.Core.Books.Authors
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryWebDbContext _dbContext;

        public AuthorRepository(LibraryWebDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddAuthor(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }

        public Author GetAuthor(string name, string surname)
        {
            var Author = _dbContext.Authors.Single(x => x.Name == name && x.Surname == surname);
            _dbContext.SaveChanges();
            return Author;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _dbContext.Authors.ToList();
        }

        public void DeleteAuthor(Author author)
        {
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }
    }
}
