namespace bruto;

class Program
{
    static void Main(string[] args)
    {
        double[] brutoSalarissen = new double[] { 13450.80, 85698.90, 39598.23 };
        double[] nettoSalarissen = new double[3];
        nettoSalarissen[0] = brutoSalarissen[0] * (1 - 0.3582);
        Console.WriteLine($"persoon 1 houdt {nettoSalarissen[0]} netto over van {brutoSalarissen[0]} bruto");
        nettoSalarissen[1] = brutoSalarissen[1] * (1 - 0.3582);
        Console.WriteLine($"persoon 2 houdt {nettoSalarissen[1]} netto over van {brutoSalarissen[1]} bruto");
        nettoSalarissen[2] = brutoSalarissen[2] * (1 - 0.3582);
        Console.WriteLine($"persoon 3 houdt {nettoSalarissen[2]} netto over van {brutoSalarissen[2]} bruto");
    }
}
