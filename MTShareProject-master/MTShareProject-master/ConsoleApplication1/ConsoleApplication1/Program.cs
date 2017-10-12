using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string input;
            RService rService = new RService();

            do
            {
                Console.WriteLine("\r\nEnter R code:");
                input = Console.ReadLine();

                rService.RunCode(input);
            }
            while (!string.IsNullOrEmpty(input));

        }
    }
}
