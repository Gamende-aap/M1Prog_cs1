namespace arraycalc;

class Program
{
    static void Main(string[] args)
    {
        double[] Saldo = new double[]{240.99, 1142.23, 789.89, 658.72};
        for (int i = 0; i < Saldo.Length; i++)
        {
            Console.WriteLine($"{i} {Saldo[i]}");
        }
        
        double[] SaldoNa = new double[]{240.99 + 100, 1142.23 + 100, 789.89 + 100, 658.72 + 100};
         for (int i = 0; i < SaldoNa.Length; i++)
        {
            Console.WriteLine($"{i} Saldo na verhooging {SaldoNa[i]}");
         }
    }
}
