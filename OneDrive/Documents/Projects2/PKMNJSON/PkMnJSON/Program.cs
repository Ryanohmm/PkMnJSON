using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pokémon Daycare Center ===\n");

        string filePath = "daycare.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: daycare.json not found.");
            return;
        }

        string json = File.ReadAllText(filePath);

        Daycare daycare = JsonSerializer.Deserialize<Daycare>(json);

        Console.WriteLine($"Total Pokémon in Daycare: {daycare.Pokemon.Count}\n");

        foreach (var p in daycare.Pokemon)
        {
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"Species: {p.Species}");
            Console.WriteLine($"Level: {p.Level}");
            Console.WriteLine($"Trainer: {p.Trainer}");
            Console.WriteLine($"Status: {(p.IsEgg ? "Egg (Incubating)" : "Active Pokémon")}");
            Console.WriteLine("-----------------------------------");
        }

        Console.WriteLine("\nThanks for visiting the Pokémon Daycare!");
    }
}
