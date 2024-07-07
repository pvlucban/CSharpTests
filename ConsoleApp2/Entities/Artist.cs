namespace ConsoleApp2.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Cover> Covers { get; set; } = new();

        public ArtistType ArtistType { get; set; }

        public PersonName PersonName { get; set; }
    }

    public enum ArtistType
    {
        Musician,
        Painter,
        NA
    }
}
