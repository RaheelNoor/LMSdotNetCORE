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








        //private readonly ApplicationDbContext _context;

        //public AuthorsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: api/authors
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        //{
        //    return Ok(await _context.Authors.ToListAsync());
        //}

        //// GET: api/authors/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Author>> GetAuthor(int id)
        //{
        //    var author = await _context.Authors.FindAsync(id);
        //    if (author == null)
        //        return NotFound(new { message = "Author not found" });

        //    return Ok(author);
        //}

        //// POST: api/authors (Create)
        //[HttpPost]
        //public async Task<ActionResult<Author>> CreateAuthor([FromBody] Author author)
        //{
        //    if (author == null)
        //        return BadRequest(new { message = "Invalid author data" });

        //    _context.Authors.Add(author);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetAuthor), new { id = author.AuthorID }, author);
        //}

        //// PUT: api/authors/5 (Update)
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateAuthor(int id, [FromBody] Author author)
        //{
        //    if (id != author.AuthorID)
        //        return BadRequest(new { message = "Author ID mismatch" });

        //    var existingAuthor = await _context.Authors.FindAsync(id);
        //    if (existingAuthor == null)
        //        return NotFound(new { message = "Author not found" });

        //    existingAuthor.FirstName = author.FirstName;
        //    existingAuthor.LastName = author.LastName;
        //    existingAuthor.Bio = author.Bio;

        //    await _context.SaveChangesAsync();
        //    return Ok(new { message = "Author updated successfully" });
        //}

        //// DELETE: api/authors/5 (Delete)
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAuthor(int id)
        //{
        //    var author = await _context.Authors.FindAsync(id);
        //    if (author == null)
        //        return NotFound(new { message = "Author not found" });

        //    _context.Authors.Remove(author);
        //    await _context.SaveChangesAsync();

        //    return Ok(new { message = "Author deleted successfully" });
        //}
    }
}