﻿using Umbrella;

class Program
{
    static void Main(string[] args)
    {
        var app = new Application();
        app.Run();
        
        Console.WriteLine("Exiting the program...");
        Console.ReadKey(); // Keep the console window open
    }
}