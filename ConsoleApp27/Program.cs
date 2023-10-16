using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числото n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i += 1)
            {
                Console.WriteLine(new string('*', n));
            }

        }    
    }
}
