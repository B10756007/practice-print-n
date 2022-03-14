using System;

namespace practice_print_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入N:");

            int x;
            x = int.Parse(Console.ReadLine());

            for(int a = 0; a < x; a++)
            {
                for(int b = 0; b < a + 1; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
