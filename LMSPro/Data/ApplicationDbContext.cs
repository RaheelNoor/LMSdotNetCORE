using Microsoft.EntityFrameworkCore;
using LMSPro.Model;

namespace LMSPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<BookCategories> BookCategories { get; set; }
        public DbSet<PublishBranches> PublishBranches { get; set; }
        public DbSet<Loans> Loans { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BookCopies> BookCopies { get; set; }
        //Views Tables 
        public DbSet<AllBooksView> V_AllBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>().HasKey(a => a.AuthorID);
            modelBuilder.Entity<BookCategories>().HasKey(c => c.CategoryID);
            modelBuilder.Entity<Books>().HasKey(b => b.BookID);
            modelBuilder.Entity<Publishers>().HasKey(p => p.PublisherID);
            modelBuilder.Entity<PublishBranches>().HasKey(p => p.BranchID);
            modelBuilder.Entity<Loans>().HasKey(p => p.LoanID);
            modelBuilder.Entity<Users>().HasKey(p => p.UserID);
            modelBuilder.Entity<BookCopies>().HasKey(p => p.CopyID);
            modelBuilder.Entity<Loans>().HasOne(l => l.BookCopy).WithMany().HasForeignKey(l => l.CopyID).OnDelete(DeleteBehavior.Restrict);
            //Views 
            modelBuilder.Entity<AllBooksView>().HasKey(p => p.BookNumber);
        }
    }
}
