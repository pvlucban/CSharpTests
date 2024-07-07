using ConsoleApp2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp2
{
    public class ApplicationDbContext: DbContext
    {
     //   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     //: base(options)
     //   {
           
     //   }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books{ get; set; }

        public DbSet<Artist> Artists{ get; set; }

        public DbSet<Cover> Covers { get; set; }
        public DbSet<Employee> Employees{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TESTEF;User Id=sa;Password=p@ssw0rd;Encrypt=false;TrustServerCertificate=true");
           // optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //base.ConfigureConventions(configurationBuilder);
            configurationBuilder.ComplexProperties<PersonName>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasData(GetAuthorsPreDefinedData());
            modelBuilder.Entity<Book>().HasData(GetBooksPreDefinedData());
            modelBuilder.Entity<Artist>().HasData(GetArtistsPreDefinedData());
            modelBuilder.Entity<Cover>().HasData(GetCoverPreDefinedData());
            modelBuilder.Entity<Artist>().Property(artist=>artist.ArtistType).HasDefaultValue(ArtistType.NA).HasConversion<string>();
            modelBuilder.Entity<Employee>().OwnsMany(p => p.Contacts, navBuilder => { navBuilder.ToJson(); } );

            //modelBuilder.Entity<Employee>().ComplexProperty(a => a.PersonName);


        }

      


        private List<Author> GetAuthorsPreDefinedData()
        {
            var retVal = new List<Author>();

            for(int i = 0; i<=10000; i++)
            {
                var author = new Author() { Name = $"Test Author {i}", Id=i+1 };
                retVal.Add(author);
            }
            return retVal;
        }

        private List<Book> GetBooksPreDefinedData()
        {
            var retVal = new List<Book>();
            for (int i = 0; i <= 10000; i++)
            {
                var authorId = i + 1;
                var book = new Book() { Title = $"Test Book {i} of {i}", AuthorId = authorId, Id = authorId, PublishDate = new DateOnly(2024, 7, 5) };
                retVal.Add(book);
            }
            return retVal;
        }

        private List<Artist> GetArtistsPreDefinedData()
        {
            var retVal = new List<Artist>();
            for (int i = 0; i <= 100; i++)
            {
                var artistId = i + 1;
                var artist = new Artist() { Name = $"Test Artist {i}",  Id = artistId };
                retVal.Add(artist);
            }
            return retVal;
        }

        private List<Cover> GetCoverPreDefinedData()
        {
            var retVal = new List<Cover>();
            for (int i = 0; i <= 100; i++)
            {
                var coverId = i + 1;
                var artist = new Cover() { DesignIdeas = $"DesignIdeas {i}", Id = coverId, DigitalOnly = true };
                retVal.Add(artist);
            }
            return retVal;
        }
    }
}
