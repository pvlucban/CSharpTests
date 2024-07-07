// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Threading.Channels;

var channel = Channel.CreateUnbounded<int>();

Task producer = Task.Run(async () =>
{
    for (int i = 0; i < 100; i++)
    {
        await channel.Writer.WriteAsync(i);
    }
    channel.Writer.Complete();
});


Task consumer = Task.Run(async () =>
{
    await foreach(var item in channel.Reader.ReadAllAsync())
    {

    }

    /*
    await foreach (var item in channel.Reader.ReadAllAsync())
    {
        // Parallel processing of the data item
        Parallel.ForEach(new[] { item }, number =>
        {
            Console.WriteLine($"Processing {number}");
            // Simulate some processing work
            //Task.Delay(100).Wait();
        });
    }
    */
});

await Task.WhenAll(producer, consumer);

Console.ReadKey();