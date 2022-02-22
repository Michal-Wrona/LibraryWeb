using LibraryWeb.Core.Persons;
using LibraryWeb.Core.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.BookBorrowings
{
    public class BookBorrowing
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int PersonId { get; set; }

        public Book Book { get; set; }

        public Person Person { get; set; }
    }
}
