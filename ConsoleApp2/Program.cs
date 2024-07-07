using Microsoft.EntityFrameworkCore;
using EFCore.BulkExtensions;
using ConsoleApp2.Entities;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {


            //FibonacciSeries(5);

            using var dbContext = new ApplicationDbContext();

            using var dbTransaction = dbContext.Database.BeginTransaction();
            try
            {
              
                var artist = await dbContext.Artists.FirstOrDefaultAsync(a => a.Id == 1);
                artist.PersonName.First = "Propcopio";
                artist.PersonName.First = "Karnenas";
                await dbContext.SaveChangesAsync();
                await dbContext.Artists.Where(a => a.Id == 2).ExecuteDeleteAsync();
                dbTransaction.Commit();
            }
            catch(Exception ex)
            {

            }
            

            //var artist = await dbContext.Artists.FirstOrDefaultAsync(a => a.ArtistType == ArtistType.Musician);
            //artist.ArtistType = ArtistType.Musician;
            //await dbContext.SaveChangesAsync();

            //Console.WriteLine($"Artist Type: {artist.ArtistType}");

            //var employee = new Employee
            //{
            //    //Id = 1,
            //    Name = "Paul",
            //    Contacts = new List<Contact>() {
            //    new Contact() { CountryCode = "65",Number = "8123"  }
            //   }
            //};

            var employee = await dbContext.Employees.Where(e=>e.Name=="Paul").Select(e=> new { e.Name}).FirstOrDefaultAsync();
            //employee.Tags.AddRange(["Pvlucban", "Test"]);
           // employee.PersonName.First = "Paul William";
            //employee.PersonName.Last = "Lucban";

            //dbContext.Employees.Add(employee);
            try
            {
               // await dbContext.SaveChangesAsync();
                Console.WriteLine(employee.Name);
            }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
          
            //var author = new Author() { Name = "Test" };

            //var author = await dbContext.Authors.Include(a=>a.Books).FirstOrDefaultAsync(a=>a.Name=="Test");
            //var author = await dbContext.Authors.FirstOrDefaultAsync(a => a.Id == 1);
            //            author = await dbContext.Authors.FirstAsync(a => a.Name == "Test");
            //          author = await dbContext.Authors.FirstAsync(a => a.Name == "Test");
            //var books = author.Books;
            //await dbContext.Entry(author).Collection(a => a.Books).LoadAsync();
            //var books = author.Books;
            ///author.Books.AddRange(new List<Book>() { new Book() { PublishDate = DateOnly.FromDateTime(DateTime.Now), Title = "Book 2" } });
            //dbContext.Authors.Add(author);
            //await dbContext.SaveChangesAsync();

            //var covers = await dbContext.Covers.Where(a => a.Id <= 10).ToListAsync();
            //var artist = await dbContext.Artists.FindAsync(1);
            //artist.Covers.AddRange(covers);
            //await dbContext.SaveChangesAsync();


            //var artists = await dbContext.Artists.Include(artist=>artist.Covers).Where(artist => artist.Covers.Any()).ToListAsync();

            //var authors = await dbContext.Authors.Skip(1 * 10).Take(10).ToListAsync();

            //dbContext.Authors.FromSql(String.Forma);

            ///  dbContext.Authors.FromSql($"Select * from Authors where Id={0}");

            //var sentence = "My Name is Paul";

            //Console.Write(sentence.Split(" ").Length);

            //for(int i=0; i<sentence.Length; i++)
            //{
            //    var c = sentence.Substring(i, 1);
            //    if(c==" " && i+1< sentence.Length)
            //    {

            //    }
            //}

            //int[] test = [1, 3, 2, 7, 5];
            //var currentNumber = 0;
            //foreach(int i in test)
            //{
            //    if(currentNumber<i)
            //    {
            //        currentNumber = i;
            //    }
            //}

            //Console.WriteLine(currentNumber);


            //int wordCounter = 0;
            //foreach (var c in sentence)
            //{
            //    if (c == ' ')
            //    {
            //        wordCounter++;
            //    }
            //}




            //Console.Write(wordCounter+1);

            Console.ReadKey();

        }
    

        static void FibonacciSeries(int num)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i<num; i++)
            {
                var temp = b;
                b = a + b;
                a = temp;
                Console.WriteLine(b);
            }

        }
    
    
    }
}
