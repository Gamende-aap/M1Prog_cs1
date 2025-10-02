using System.Globalization;

namespace als;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Je zoekt de sleutel");
        Console.WriteLine("Heb je de sleutel gevonden? (Y/N)");

        string input = Console.ReadLine();
        bool sleutelKwijt = input == "N" || "n" == input;


        if (sleutelKwijt)
        {
            Console.WriteLine("Je bent je sleutel kwijt!");
            Console.WriteLine("De deur blijft gesloten");
        }
        else
        {
            Console.WriteLine("De deur gaat open je kan naar binnen");
        }
    }
}
