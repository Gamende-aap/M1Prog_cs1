namespace uitvragen;

class Program
{
    static void Main(string[] args)
    {
        double[] percentages = new double[5] { .05, .10, .15, .20, .25 };

        double temp = percentages[3];
        temp = percentages[0];
        Console.WriteLine(temp);
        temp = percentages[1];
        Console.WriteLine(temp);
        temp = percentages[2];
        Console.WriteLine(temp);
        temp = percentages[3];
        Console.WriteLine(temp);
        temp = percentages[4];
        Console.WriteLine(temp);


 
    }
}
