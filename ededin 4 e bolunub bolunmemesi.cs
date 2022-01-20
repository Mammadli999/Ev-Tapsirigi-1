using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir Reqem Yaz");

            int reqem = Convert.ToInt32(Console.ReadLine());

            int a = reqem % 4;

            if (a == 0)
            {
                Console.WriteLine("Bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
            Console.ReadKey();



























        }
    }
}
