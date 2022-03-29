using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Api.Books.Authors
{
    public class GetAuthorReturnDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
