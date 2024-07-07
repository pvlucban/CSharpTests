using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateOnly PublishDate { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public  Author Author { get; set; }

    }
}
