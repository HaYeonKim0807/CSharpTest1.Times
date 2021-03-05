using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {

                for (int b = 1; b <= 9; b++)
                {
                    int result = a * b;
                    Console.WriteLine("{0}X{1}={2}", a, b, result);

                }

            }

        }
    }
}
