namespace math;

class Program
{
    static void Main(string[] args)
    {
        double kleiner = 9;
        double groter = 19;
        double welkeIsKleiner = Math.Min(kleiner, groter);
        Console.WriteLine($"{welkeIsKleiner} is de kleinste van {kleiner} en {groter}");

        double welkeIsGroter = Math.Max(kleiner, groter);
        Console.WriteLine($"{welkeIsGroter} is de grootste van {kleiner} en {groter}");

        double waarde = 16;
        double min = 20;
        double max = 30;
        double beperkt = Math.Clamp(waarde, min, max);
        Console.WriteLine($"Het clamp resultaat van {waarde} met min {min} en max {max} is {beperkt}");

        double getal = 16;
        double wortel = Math.Sqrt(getal);
        Console.WriteLine($"De wortel van {getal} is {wortel}");
    }
}
