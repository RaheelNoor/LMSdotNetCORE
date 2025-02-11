using LMSPro.Model;

namespace LMSPro.Repository.InterFace
{
    public interface IBooks
    {
        public IEnumerable<Books> GetBooks();
        Books GetBookById(int id);
        public Books PostBook(Books book);
        Books UpdateBook(int id, Books book);
        bool DeleteBook(int id);
        public IEnumerable<AllBooksView> AllViewBooks();
        // Books Catogry interfaces 
        public IEnumerable<BookCategories> GetBookCategories();
        public BookCategories PostBookCategories(BookCategories bookCatogry);
        bool DeleteBookCategories(int id);
        // Books Publisher interfaces 
        public IEnumerable<Publishers> GetBookPublisher();
        public Publishers PostBookPublisher(Publishers publisher);
        bool DeleteBookPublisher(int id);
        // Books Publisher Branches interfaces 
        public IEnumerable<PublishBranches> GetBookPublisherBranch();
        public PublishBranches PostBookPublisherBranch(PublishBranches branch);
        bool DeleteBookPublisherBranch(int id);
        // Books Copies interfaces 
        public IEnumerable<BookCopies> GetBookCopies();
        public BookCopies PostBookCopies(BookCopies copy);
        bool DeleteBookCopies(int id);
    }

    //public interface IBookCategories
    //{
    //    public IEnumerable<BookCategories> GetBookCategories();
    //    public BookCategories PostBookCategories(BookCategories bookCatogry);
    //    bool DeleteBookCategories(int id);
    //}
}
