using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWhitASPNET5.Business;
using RestWhitASPNET5.Models;

namespace RestWhitASPNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{vaersion:apiVersion}")]
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> logger;
        private readonly IBooksBusiness booksBusiness;

        public BooksController(ILogger<BooksController> logger, IBooksBusiness booksBusiness)
        {
            this.logger = logger;
            this.booksBusiness = booksBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(booksBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var books = booksBusiness.FindById(id);
            if (books == null)
                NotFound();

            return Ok(books);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Books books)
        {
            if (books == null)
                BadRequest();

            return Ok(booksBusiness.Create(books));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Books books)
        {
            if (books == null)
                BadRequest();

            return Ok(booksBusiness.Update(books));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id) 
        {
            booksBusiness.Delete(id);

            return NoContent();
        }
    }
}
