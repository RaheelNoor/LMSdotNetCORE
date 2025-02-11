using LMSPro.Model;
using LMSPro.Repository.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LMSPro.Controllers
{
    [Route("api/[controller]")]  
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthors _authorService; 

        public AuthorsController(IAuthors authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IEnumerable<Authors> GetAuthors()
        {
            return _authorService.GetAuthors();
        }

        [HttpGet("{id}")]
        public ActionResult<Authors> GetAuthorById(int id)
        {
            var author = _authorService.GetAuthorById(id);
            if (author == null) return NotFound("Not Found");
            return author;
        }

        [HttpPost]
        public ActionResult<Authors> PostAuthor(Authors author)
        {
            return _authorService.PostAuthor(author);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, Authors author)
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