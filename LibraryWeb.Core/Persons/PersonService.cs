using LibraryWeb.Core.OperationHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.Persons
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public OperationResult AddPerson(Person personToAdd)
        {
            //if (string.IsNullOrEmpty(personToAdd.Surname))

                return new OperationResult { ErrorMessage = "Missing all surname" };

            //else if (!string.IsNullOrEmpty(personToAdd.Surname))
            //{
            //    _personRepository.
            //}
        }

        public OperationResult DeletePerson(int idPerson)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPersons()
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdatePerson()
        {
            throw new NotImplementedException();
        }
    }
}
