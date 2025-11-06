namespace autoclass;

class Program
{
    static void Main(string[] args)
    {
        Auto mijnAuto = new Auto();
        Console.WriteLine(mijnAuto);
        Console.WriteLine(mijnAuto);

        Console.WriteLine("");
        
        mijnAuto.Merk = "BMW";
        mijnAuto.Bouwjaar = 2009;
        Console.WriteLine("Eerste Auto");
        Console.WriteLine("Auto Merk: " + mijnAuto.Merk);
        Console.WriteLine("Auto Bouwjaar: " + mijnAuto.Bouwjaar);

        Console.WriteLine("");

        mijnAuto.Merk = "Audi";
        mijnAuto.Bouwjaar = 2015;
        Console.WriteLine("Tweede Auto");
        Console.WriteLine("Auto Merk: " + mijnAuto.Merk);
        Console.WriteLine("Auto Bouwjaar: " + mijnAuto.Bouwjaar);
    }
}
