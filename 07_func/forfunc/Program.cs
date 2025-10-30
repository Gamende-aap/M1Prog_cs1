namespace forfunc;

class Program
{
    static void Main(string[] args)
    {
        double[] basis = { 2, 4, 6, 8 };

        foreach (double getal in basis)
        {
            double temp = getal;

            double resultaat = Math.Pow(temp, 2);

            Console.WriteLine($"{temp} tot de macht 2 is {resultaat}");
        }
    }
}
