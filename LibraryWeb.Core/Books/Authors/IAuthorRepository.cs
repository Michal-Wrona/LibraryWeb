using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.Books.Authors
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);

        Author GetAuthor(string name, string surname);

        IEnumerable<Author> GetAuthors();

        void DeleteAuthor(Author author);
    }
}
