using LMSPro.Model;
using LMSPro.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMSPro.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthor _authorService;

        public AuthorsController(IAuthor authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IEnumerable<Author> GetAuthors()
        {
            return _authorService.GetAuthors();
        }

        [HttpGet("{id}")]
        public ActionResult<Author> GetAuthorById(int id)
        {
            var author = _authorService.GetAuthorById(id);
            if (author == null) return NotFound("Not Found");
            return author;
        }

        [HttpPost]
        public ActionResult<Author> PostAuthor(Author author)
        {
            return _authorService.PostAuthor(author);
        }
        // i am writing this commit for test git work 
        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, Author author)
        {
            var updatedAuthor = _authorService.UpdateAuthor(id, author);
            if (updatedAuthor == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var deleted = _authorService.DeleteAuthor(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}