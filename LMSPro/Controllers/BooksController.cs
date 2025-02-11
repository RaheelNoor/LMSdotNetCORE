using LMSPro.Model;
using LMSPro.Repository;
using LMSPro.Repository.InterFace;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBooks _bookServices;
        public BooksController(IBooks bookServices)
        {
            _bookServices = bookServices;
        }
        // All Books 
        [HttpGet]
        public IEnumerable<Books> GetBooks()
        {
            return _bookServices.GetBooks();
        }
        [HttpGet("viewBooks")]
        public IEnumerable<AllBooksView> AllViewBooks()
        {
            return _bookServices.AllViewBooks();
        }
        [HttpGet("{id}")]
        public ActionResult<Books> GetBookById(int id)
        {
            var book = _bookServices.GetBookById(id);
            if (book == null) return NotFound("Not Found");
            return book;
        }

        [HttpPost]
        public ActionResult<Books> PostBook(Books Book)
        {
            return _bookServices.PostBook(Book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Books Book)
        {
            var updatedBook = _bookServices.UpdateBook(id, Book);
            if (updatedBook == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var deleted = _bookServices.DeleteBook(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
        // All Books Categories 
        [HttpGet("categories")]
        public IEnumerable<BookCategories> GetBookCategories()
        {
            return _bookServices.GetBookCategories();
        }
        [HttpPost("categories")]
        public BookCategories PostBookCategories(BookCategories bookCategories)
        {
           return _bookServices.PostBookCategories(bookCategories);
        }
        [HttpDelete("categories/{id}")]
        public IActionResult DeleteBookCatagory(int id)
        {
            var bookCatagory = _bookServices.DeleteBookCategories(id);
            if(!bookCatagory) return NotFound();
            return NoContent() ;
        }
        // All Books Publisher 
        [HttpGet("publisher")]
        public IEnumerable<Publishers> GetBookPublisher()
        {
            return _bookServices.GetBookPublisher();
        }
        [HttpPost("publisher")]
        public Publishers PostBookPublisher(Publishers publisher)
        {
            return _bookServices.PostBookPublisher(publisher);
        }
        [HttpDelete("publisher/{id}")]
        public IActionResult DeleteBookPublisher(int id)
        {
            var publisher = _bookServices.DeleteBookPublisher(id);
            if (!publisher) return NotFound();
            return NoContent();
        }
        // All Books Publisher Branches
        [HttpGet("publisherBranch")]
        public IEnumerable<PublishBranches> GetBookPublisherBranch()
        {
            return _bookServices.GetBookPublisherBranch();
        }
        [HttpPost("publisherBranch")]
        public PublishBranches PostBookPublisher(PublishBranches branch)
        {
            return _bookServices.PostBookPublisherBranch(branch);
        }
        [HttpDelete("publisherBranch/{id}")]
        public IActionResult DeleteBookPublisherBranch(int id)
        {
            var branch = _bookServices.DeleteBookPublisherBranch(id);
            if (!branch) return NotFound();
            return NoContent();
        }
        // All Books Publisher Branches
        [HttpGet("copies")]
        public IEnumerable<BookCopies> GetBookCopies()
        {
            return _bookServices.GetBookCopies();
        }
        [HttpPost("copy")]
        public BookCopies PostBookCopy(BookCopies copy)
        {
            return _bookServices.PostBookCopies(copy);
        }
        [HttpDelete("copy/{id}")]
        public IActionResult DeleteBookCopy(int id)
        {
            var branch = _bookServices.DeleteBookCopies(id);
            if (!branch) return NotFound();
            return NoContent();
        }

    }
}
