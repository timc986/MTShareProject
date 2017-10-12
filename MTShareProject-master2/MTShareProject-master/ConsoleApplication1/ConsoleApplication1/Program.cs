using System;
using ConsoleApplication1.Nlp;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string input;
            RService rService = new RService();

            NlpProgram.MainAsync().Wait();

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
