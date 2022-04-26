using LibraryWeb.Core.BookBorrowings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.Persons
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string MailAddress { get; set; }

        public DateTime AccountCreatedTime { get; set; }

        public bool IsAccountLocked { get; set; }

        public ICollection<BookBorrowing> BookBorrowings { get; set; }

       
    }
}
