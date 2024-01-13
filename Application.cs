namespace Umbrella;

public class Application
{
    public void Run()
    {
        var exitRequested = false;

        while (!exitRequested)
        {
            Console.WriteLine("Main Menu:");
            
            Console.WriteLine("1. See all upcoming");
            Console.WriteLine("2. See all");
            Console.WriteLine("3. Search");
            Console.WriteLine("9. Integrity check");
            
            Console.WriteLine("0. Exit");

            string? mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":
                    Console.WriteLine("upcoming...");
                    Task.Delay(500);
                    break;
                case "2":
                    Console.WriteLine("upcoming...");
                    Task.Delay(500);
                    break;
                case "3":
                    Console.WriteLine(PiHelper.GetPi());
                    Task.Delay(500);
                    break;
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