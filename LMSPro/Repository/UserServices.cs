using LMSPro.Data;
using LMSPro.Model;
using LMSPro.Repository.InterFace;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LMSPro.Repository
{
    public class UserServices : IUsers
    {
        private readonly ApplicationDbContext _context;
        public UserServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Users> GetUsers()
        {
            return _context.Users.ToList();
        }
        public Users SignupUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChangesAsync();
            return user;
        }
        public Users UpdateUser(int id, Users user)
        {
            var exitUser = _context.Users.Find(id);
            if (exitUser == null) return null;

            exitUser.Username = user.Username;
            exitUser.PasswordSimple = user.PasswordSimple;
            exitUser.Email = user.Email;
            exitUser.Role = user.Role;
            exitUser.Address = user.Address;
            exitUser.PhoneNumber = user.PhoneNumber;
            _context.SaveChangesAsync();
            return exitUser;
        }
        public bool DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return false;

            _context.Users.Remove(user);
            return true;

        }
        // Loans Users Api Services
        public IEnumerable<Loans> GetLoans()
        {
            return _context.Loans.ToList();
        }
        public Loans PostLoans(Loans loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChangesAsync();
            return loan;
        }
        public Loans UpdateLoans(int id, Loans loan)
        {
            var loans = _context.Loans.Find(id);
            if (loans == null) return null;

            loans.CopyID = loan.CopyID;
            loans.BranchID = loan.BranchID;
            loans.UserID = loan.UserID;
            loans.BookID = loan.BookID;
            loans.LoanDate = loan.LoanDate;
            loans.DueDate = loan.DueDate;
            loans.ReturnDate = loan.ReturnDate;
            loans.Status = loan.Status;
            _context.SaveChangesAsync();
            return loans;
        }
        public bool DeleteLoans(int id)
        {
            var loan = _context.Loans.Find(id);
            if (loan == null) return false;

            _context.Loans.Remove(loan);
            return true;
        }
    }
}
