namespace Umbrella;

public class Application
{
    public void Run()
    {
        var exitRequested = false;

        while (!exitRequested)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("0. Exit");

            string? mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "0":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}