namespace en;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Heeft de deur een sleutel nodig? (Y/N)");
        string inputDoor = Console.ReadLine().ToLower();
        bool doorNeedsKey = (inputDoor == "y");

        Console.WriteLine("Heb je een sleutel? (Y/N)");
        string inputKey = Console.ReadLine().ToLower();
        bool hasKey = (inputKey == "y");

        Console.WriteLine("Je staat voor een deur.");

        if (doorNeedsKey && hasKey)
        {
            Console.WriteLine("Je gebruikt de sleutel om de deur te openen.");
        }
        else if (doorNeedsKey && !hasKey)
        {
            Console.WriteLine("De deur zit op slot.");
        }
        else
        {
            Console.WriteLine("De deur is al open.");
        }
    }
}
