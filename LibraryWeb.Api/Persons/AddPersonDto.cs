using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Api.Persons
{
    public class AddPersonDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string MailAddress { get; set; }
    }
}
