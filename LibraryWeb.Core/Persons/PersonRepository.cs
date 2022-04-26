using LibraryWeb.Core.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryWeb.Core.Persons
{
    public class PersonRepository : IPersonRepository
    {
        private readonly LibraryWebDbContext _dbContext;

        public PersonRepository(LibraryWebDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddPerson(Person person)
        {
            _dbContext.Persons.Add(person);
            _dbContext.SaveChanges();
        }

        public Person GetPerson(string name, string surname)
        {
            var person = _dbContext.Persons.Single(x => x.Name == name && x.Surname == surname);
            _dbContext.SaveChanges();
            return person;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _dbContext.Persons.ToList();
        }

        public void DeletePerson(int id)
        {
            var person = _dbContext.Persons.SingleOrDefault(x => x.Id == id);
            _dbContext.Persons.Remove(person);
            _dbContext.SaveChanges();
        }
    }
}
