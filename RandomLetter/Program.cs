using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Tere, {firstName.ToLower()[0]}");
        }
    }
}
