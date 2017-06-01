
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCWebAPI.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISBN { set; get; }
        [Required]
        public string Title { set; get; }
        [Required]
        public string Author { set; get; }


        public string Description { set; get; }
        [Required]
        public int PublishedYear { set; get; }
    }
}