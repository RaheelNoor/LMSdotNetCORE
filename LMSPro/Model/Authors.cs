namespace LMSPro.Model
{
    public class Authors
    {
        public int AuthorID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Bio { get; set; }
    }
}
