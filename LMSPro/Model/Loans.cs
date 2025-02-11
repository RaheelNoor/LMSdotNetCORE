using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMSPro.Model
{
    public class Loans
    {
        public int LoanID { get; set; }
        public int CopyID { get; set; }
        public int UserID { get; set; }
        public int? BranchID { get; set; }
        public int? BookID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = "Loan Person";
        public virtual BookCopies BookCopy { get; set; }
        public virtual Users User { get; set; }
        public virtual PublishBranches Branch { get; set; }
        public virtual Books Book { get; set; }
    }
}
