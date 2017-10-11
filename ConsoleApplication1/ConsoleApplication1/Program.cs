using System;
using RDotNet;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            RService();

            //print out and read line 
            Console.WriteLine("Enter input:");

            string input = Console.ReadLine();

            Console.WriteLine(input);
            //natrual language processing

            //useful command eg. R

            //try to run R in C#
        }

        static void RService()
        {
            REngine.SetEnvironmentVariables(); // <-- May be omitted; the next line would call it.
            REngine engine = REngine.GetInstance();

            // A somewhat contrived but customary Hello World:
            var e = engine.Evaluate("x <- 3");
            NumericVector x = engine.GetSymbol("x").AsNumeric();
            engine.Evaluate("y <- 1:10");
            NumericVector y = engine.GetSymbol("y").AsNumeric();

            CharacterVector charVec = engine.CreateCharacterVector(new[] { "Hello, R world!, .NET speaking" });
            engine.SetSymbol("greetings", charVec);
            engine.Evaluate("str(greetings)"); // print out in the console
            string[] a = engine.Evaluate("'Hi there .NET, from the R engine'").AsCharacter().ToArray();
            Console.WriteLine("R answered: '{0}'", a[0]);
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
