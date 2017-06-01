
namespace MVCWebAPI.Models
{
    public class Book
    {
        public int ISBN { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public string Description { set; get; }
        public int PublishedYear { set; get; }
    }
}