using LibraryWeb.Api.Books;
using LibraryWeb.Core.Books;
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
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost]
        public ActionResult AddBook(AddBookDto dto)
        {
            string authorSurname = dto.AuthorSurname;
            string bookName = dto.Name;
            _bookRepository.AddBook(authorSurname, bookName);


            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<GetBookReturnDto>> GetBooks([FromQuery] string nameBook)
        {
            var books = _bookRepository.GetBooks();
            var bookList = new List<GetBookReturnDto>();

            foreach (var book in books.Where(x=>string.Equals(x.Name,nameBook, StringComparison.CurrentCultureIgnoreCase)))
            {
                bookList.Add(new GetBookReturnDto()
                {
                    Id = book.Id,
                    Name = book.Name
                    
                });

            }
            return bookList;
        }
    }
}
