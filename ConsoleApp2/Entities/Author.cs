namespace ConsoleApp2.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

        public PersonName PersonName { get; set; }

    }
}
