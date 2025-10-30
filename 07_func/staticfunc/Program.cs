namespace staticfunc;

class Program
{
    static void Main(string[] args)
    {
        SayHelloWorld();
        //SayHelloWorld();
        //SayHelloWorld();
    }

    static void SayHelloWorld()
    {
        Console.WriteLine("A long time ago in a galaxy far, far away...");
        Console.WriteLine("");
        Console.WriteLine("It is a period of civil war.");
        Console.WriteLine("Rebel spaceships, striking from a hidden base,");
        Console.WriteLine("have won their first victory against the evil Galactic Empire.");
        Console.WriteLine("");

        Console.WriteLine("During the battle, Rebel spies managed to steal secret plans");
        Console.WriteLine("to the Empire's ultimate weapon, the DEATH STAR,");
        Console.WriteLine("an armored space station with enough power to destroy an entire planet.");
        Console.WriteLine("");

        Console.WriteLine("Pursued by the Empire's sinister agents,");
        Console.WriteLine("Princess Leia races home aboard her starship,");
        Console.WriteLine("custodian of the stolen plans that can save her people");
        Console.WriteLine("and restore freedom to the galaxy...");
        AfterIntro();
    }

    static void StopApp()
    {
        Console.WriteLine("Thank you, the app will close now");
    }


    static void AfterIntro()
    {
        Console.WriteLine();
        Console.Write("Would you like to see the intro again? (y/n) ");
        string? antwoord = Console.ReadLine();

        if (antwoord == "y" || antwoord == "Y")
        {
            RestartApp();
        }
        else if (antwoord == "n" || antwoord == "N")
        {
            StopApp();
        }
        else
        {
            Console.WriteLine("Invalid input, please type y or n.");
            AfterIntro();
        }

        static void RestartApp()
        {
            SayHelloWorld();
        }
    }
}
