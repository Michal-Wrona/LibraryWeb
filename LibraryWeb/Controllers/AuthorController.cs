using LibraryWeb.Api.Books.Authors;
using LibraryWeb.Core.Books.Authors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpPost]
        public ActionResult AddAuthor(AddAuthorDto dto)
        {
            var author = new Author { Name = dto.Name, Surname = dto.Surname };

            _authorRepository.AddAuthor(author);

            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<GetAuthorReturnDto>> GetAuthors([FromQuery] string name, [FromQuery] string surname)
        {
            var authors = _authorRepository.GetAuthors();
            var authorsList = new List<GetAuthorReturnDto>();

            foreach (var author in authors.Where(x=> string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase) && string.Equals(x.Surname, surname, StringComparison.CurrentCultureIgnoreCase)))
            {
                authorsList.Add(new GetAuthorReturnDto()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Surname = author.Surname
                });

            }
            return authorsList;
        }

        [HttpDelete]
        public ActionResult DeleteAuthor(DeleteAuthorDto dto)
        {
            var author = new Author { Id = dto.Id, Surname = dto.Surname };
            _authorRepository.DeleteAuthor(author);

            return Ok();

        }
    }

}
