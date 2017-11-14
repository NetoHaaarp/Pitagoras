using System;
namespace prog
{
    class Pitagoras
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Teorema de pitagoras");
            Console.WriteLine("Inserte a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte b");
            double b = double.Parse(Console.ReadLine());
            a = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("h = " + a);

            Console.ReadKey();
        }

    }
}