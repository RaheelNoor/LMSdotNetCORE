namespace LMSPro.Model
{
    public class Books
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string BookNumber { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public int CategoryID { get; set; }
        public int? PublicationYear { get; set; }

        // Navigation properties (optional, for Entity Framework relationships)
        public virtual Authors Author { get; set; }
        public virtual Publishers Publisher { get; set; }
        public virtual BookCategories Category { get; set; }
        //ksdjfklsdfsdkl
    }
}
