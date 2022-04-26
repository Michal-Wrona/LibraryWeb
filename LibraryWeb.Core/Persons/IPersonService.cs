using LibraryWeb.Core.OperationHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.Persons
{
    public interface IPersonService
    {
        OperationResult AddPerson(Person personToAdd);
        OperationResult DeletePerson(int idPerson);
        IEnumerable<Person> GetPersons();
        OperationResult UpdatePerson();
    }
}
