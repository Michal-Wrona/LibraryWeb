using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Api.Books
{
    public class GetBookReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorSurname { get; set; }
    }
}
