using System;

namespace forif;

class Program
{
    static void Main(string[] args)
    {
        int[] Nummers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 3; i < Nummers.Length -2; i++)
        {
            Console.WriteLine($"{Nummers[i]}");
        }
    }
}