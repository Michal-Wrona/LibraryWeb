using LibraryWeb.Api.Persons;
using LibraryWeb.Core.Persons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LibraryWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController (IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public ActionResult <IList<GetPersonReturnDto>> GetPersons([FromQuery] string name, [FromQuery] string surname)
        {
            var persons = _personRepository.GetPersons();
            var personsList = new List<GetPersonReturnDto>();

            foreach (var person in persons.Where(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase) && string.Equals (x.Surname, surname, StringComparison.CurrentCultureIgnoreCase)))
            {
                personsList.Add(new GetPersonReturnDto()
                {
                    Id = person.Id,
                    MailAddress = person.MailAddress,
                    Name = person.Name,
                    Surname = person.Surname
                });


            }

            return Ok(personsList);
        }

        [HttpPost]
        public ActionResult AddPerson(AddPersonDto dto)
        {
            var person = new Person { Name = dto.Name, Surname = dto.Surname, MailAddress = dto.MailAddress };

            _personRepository.AddPerson(person);

            return Ok();

        }
    }
}
