namespace LMSPro.Model
{
    public class BookCopies
    {
        public int CopyID { get; set; }

        public int BookID { get; set; }

        public int BranchID { get; set; }

        public string Status { get; set; } = "Available";

        public virtual Books Book { get; set; }

        public virtual PublishBranches Branch { get; set; }
    }
}
