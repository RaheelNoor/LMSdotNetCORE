using LMSPro.Model;

namespace LMSPro.Repository.InterFace
{
    public interface IUsers
    {
        // Users interface
        public IEnumerable<Users> GetUsers();
        public Users SignupUser(Users user);
        Users UpdateUser(int id, Users user);
        bool DeleteUser(int id);
        // Loans Users interfaces
        public IEnumerable<Loans> GetLoans();
        public Loans PostLoans(Loans loan);
        Loans UpdateLoans(int id, Loans loan);
        bool DeleteLoans(int id);
    }
}
