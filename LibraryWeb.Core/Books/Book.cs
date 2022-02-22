using System;
using System.Collections.Generic;
using System.Text;
using LibraryWeb.Core.Books.Authors;

namespace LibraryWeb.Core.Books
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
