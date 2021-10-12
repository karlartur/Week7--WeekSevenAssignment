using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {lastName}");

            Console.Read();

        }
    }
}
