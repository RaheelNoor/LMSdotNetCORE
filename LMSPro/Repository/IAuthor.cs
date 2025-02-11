using LMSPro.Model;

namespace LMSPro.Repository.InterFace
{
    public interface IAuthors
    {
        public IEnumerable<Authors> GetAuthors();
        Authors GetAuthorById(int id);
        public Authors PostAuthor(Authors author);
        Authors UpdateAuthor(int id, Authors author);
        bool DeleteAuthor(int id);
    }
}
