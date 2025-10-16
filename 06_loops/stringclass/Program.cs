using System.Runtime.CompilerServices;

namespace stringclass;

class Program
{
    static void Main(string[] args)
    {
        string[] geenCaps = { "Global", "Variable", "class" };
        

        for (int i = 0; i < geenCaps.Length; i++)
        {
        Console.WriteLine(geenCaps[i]);
        Console.WriteLine($"Is een Variable die " + geenCaps[i].Length + " lang is");
        Console.WriteLine(geenCaps[i].ToUpper()); 
         
        }
    }
}
