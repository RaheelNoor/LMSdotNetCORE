using LMSPro.Data;
using LMSPro.Model;
using LMSPro.Repository.InterFace;

namespace LMSPro.Repository
{
    public class BookService : IBooks
    {
        private readonly ApplicationDbContext _context;
        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }
        // All Books Add , update, delete, Get Information 
        public IEnumerable<Books> GetBooks()
        {
            return _context.Books.ToList();
        }
        public IEnumerable<AllBooksView> AllViewBooks()
        {
            return _context.V_AllBooks.ToList();
        }
        public Books GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public Books PostBook(Books book)
        {
            _context.Books.Add(book);
            _context.SaveChangesAsync();
            return book;
        }

        public Books UpdateBook(int id, Books book)
        {
            var existingBook = _context.Books.Find(id);
            if (existingBook == null) return null;

            existingBook.Title = book.Title;
            existingBook.BookNumber = book.BookNumber;
            existingBook.AuthorID = book.AuthorID;
            existingBook.PublisherID = book.PublisherID;
            existingBook.CategoryID = book.CategoryID;
            existingBook.PublicationYear = book.PublicationYear;

            _context.SaveChangesAsync();
            return existingBook;
        }

        public bool DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return false;

            _context.Books.Remove(book);
            _context.SaveChangesAsync();
            return true;
        }
        // All Books Catagory Add , update, delete, Get Information 
        public IEnumerable<BookCategories> GetBookCategories()
        {
            return _context.BookCategories.ToList();
        }

        public BookCategories PostBookCategories(BookCategories bookCatogry)
        {
            _context.BookCategories.Add(bookCatogry);
            _context.SaveChangesAsync();
            return bookCatogry;
        }

        public bool DeleteBookCategories(int id)
        {
            var bookCatogry = _context.BookCategories.Find(id);
            if (bookCatogry == null) return false;

            _context.BookCategories.Remove(bookCatogry);
            _context.SaveChangesAsync();
            return true;
        }
        // All Books Publisher Add , update, delete, Get Information 
        public IEnumerable<Publishers> GetBookPublisher()
        {
            return _context.Publishers.ToList();
        }

        public Publishers PostBookPublisher(Publishers publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChangesAsync();
            return publisher;
        }

        public bool DeleteBookPublisher(int id)
        {
            var publisher = _context.Publishers.Find(id);
            if (publisher == null) return false;

            _context.Publishers.Remove(publisher);
            _context.SaveChangesAsync();
            return true;
        }
        // All Books Publisher Branches Add , update, delete, Get Information 
        public IEnumerable<PublishBranches> GetBookPublisherBranch()
        {
            return _context.PublishBranches.ToList();
        }

        public PublishBranches PostBookPublisherBranch(PublishBranches branch)
        {                      
            _context.PublishBranches.Add(branch);
            _context.SaveChangesAsync();
            return branch;
        }

        public bool DeleteBookPublisherBranch(int id)
        {
            var branch = _context.PublishBranches.Find(id);
            if (branch == null) return false;

            _context.PublishBranches.Remove(branch);
            _context.SaveChangesAsync();
            return true;
        }
        // All Books copies Add , update, delete, Get Information 
        public IEnumerable<BookCopies> GetBookCopies()
        {
            return _context.BookCopies.ToList();
        }

        public BookCopies PostBookCopies(BookCopies copy)
        {
            _context.BookCopies.Add(copy);
            _context.SaveChangesAsync();
            return copy;
        }

        public bool DeleteBookCopies(int id)
        {
            var copy = _context.BookCopies.Find(id);
            if (copy == null) return false;

            _context.BookCopies.Remove(copy);
            _context.SaveChangesAsync();
            return true;
        }
    }
}
