namespace basicloop;

class Program
{
    static void Main(string[] args)
    {
        int[] Nummers = new int[]{42, 60, 89};
         for (int i = 0; i < Nummers.Length; i++)
        {
            
            Console.WriteLine($"{i + 1}: {Nummers[i]}");
         }
    }
}  
