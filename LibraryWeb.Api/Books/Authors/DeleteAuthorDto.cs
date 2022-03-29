using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Api.Books.Authors
{
    public class DeleteAuthorDto
    {
        public int Id { get; set; }
        public string Surname { get; set; }
    }
}
