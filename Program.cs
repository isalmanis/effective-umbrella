using Microsoft.Extensions.Configuration;
using Umbrella;
using Umbrella.Services;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var logger = new SimpleLogger();
            logger.LogInfo("Starting...");
            var config = new ConfigurationBuilder()
                .AddJsonFile("local.settings.json", true, true)
                .Build();
            logger.LogInfo("Config built");
            var app = new Application();
            app.Run();
            logger.LogInfo("Exiting the program...");
            Console.ReadKey(); // Keep the console window open
        }
        catch (Exception e)
        {
            
        }

    }
}