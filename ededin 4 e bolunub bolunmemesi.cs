using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 84;

            int b = a % 4;

            if (b == 0)
            {
                Console.WriteLine("Bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
            Console.ReadKey();

            /*
            Console.WriteLine("Bir Reqem Yaz");

            int reqem = Convert.ToInt32(Console.ReadLine());

            int a = reqem % 4;

            if (a == 0)                                           // Belede elemey mumkundur
            {
                Console.WriteLine("Bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
            Console.ReadKey();
            */



























        }
    }
}
