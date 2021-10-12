using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string user = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string parool = Console.ReadLine();
                Console.WriteLine("Sisesta PIN:");
                string PIN = Console.ReadLine();
                if (PIN.Length > 4)
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                }
                else if (user == "user1" && parool == "password1" && PIN == "1532")
                {
                    Console.WriteLine("Tere tulemast.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Midagi läks valesti {3 - 1} katset alles. Proovi uuesti.");
                    i = i + 1
                }
            }
            
        }
    }
}
