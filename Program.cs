using Microsoft.Extensions.Configuration;
using Umbrella;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("local.settings.json", true, true)
            .Build();
        
        var app = new Application();
        app.Run();
        
        Console.WriteLine("Exiting the program...");
        Console.ReadKey(); // Keep the console window open
    }
}