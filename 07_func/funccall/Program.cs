namespace funccall;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Clear();

        Console.Write("....X....");

        Console.SetCursorPosition(4, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("?");
        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("X Was nothing");
        Console.WriteLine();
        Console.WriteLine("De ? hierboven is rood!");

    }
}
