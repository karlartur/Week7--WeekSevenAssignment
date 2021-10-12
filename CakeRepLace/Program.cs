using System;

namespace CakeRepLace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "the c4ke i3 4 11e";
            Console.WriteLine($"{cake}.", cake);
            cake = cake.Replace("4", "a").Replace("3", "s").Replace("1", "i");
            Console.WriteLine($"{cake}", cake);
        }
    }
}
