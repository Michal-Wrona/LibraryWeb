using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.Persons
{
    public interface IPersonRepository
    {
        Person GetPerson(string name, string surname);

        IEnumerable<Person> GetPersons();

        void AddPerson(Person person);
        void DeletePerson(int id);
    }
}
