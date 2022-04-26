using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Api.Books
{
    public class AddBookDto
    {
        public string Name { get; set; }

        public string AuthorSurname { get; set; }
    }
}
