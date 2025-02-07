using LMSPro.Model;

namespace LMSPro.Repository
{
    public interface IAuthor
    {
        public IEnumerable<Author> GetAuthors();
        Author GetAuthorById(int id);
        public Author PostAuthor(Author author);
        Author UpdateAuthor(int id, Author author);
        bool DeleteAuthor(int id);
    }
}
