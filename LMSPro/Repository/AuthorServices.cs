using LMSPro.Data;
using LMSPro.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LMSPro.Repository
{
    public class AuthorServices : IAuthor
    {
        private readonly ApplicationDbContext _context;
        public AuthorServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.Find(id);
        }

        public Author PostAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChangesAsync();
            return author;
        }

        public Author UpdateAuthor(int id, Author author)
        {
            var existingAuthor = _context.Authors.Find(id);
            if (existingAuthor == null) return null;

            existingAuthor.FirstName = author.FirstName;
            existingAuthor.LastName = author.LastName;
            existingAuthor.Bio = author.Bio;

            _context.SaveChanges();
            return existingAuthor;
        }

        public bool DeleteAuthor(int id)
        {
            var author = _context.Authors.Find(id);
            if (author == null) return false;

            _context.Authors.Remove(author);
            _context.SaveChanges();
            return true;
        }
    }
}
