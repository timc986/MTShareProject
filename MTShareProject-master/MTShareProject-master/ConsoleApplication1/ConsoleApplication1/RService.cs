using System;
using RDotNet;

namespace ConsoleApplication1
{
    public class RService
    {
        private readonly REngine _rEngine;

        public RService()
        {
            REngine.SetEnvironmentVariables();
            _rEngine = REngine.GetInstance();
        }

        public void RunCode(string input)
        {
            try
            {
                var e = _rEngine.Evaluate(input); //result from R code will be print out
            }
            catch (Exception e)
            {
                //Console.WriteLine(exception);
                //throw;
            }

            string[] a = _rEngine.Evaluate("'from the R.NET engine'").AsCharacter().ToArray();
        }

        //static void RService()
        //{
        //    REngine.SetEnvironmentVariables();
        //    REngine engine = REngine.GetInstance();

        //    var e = engine.Evaluate("x <- 3"); //result from R code will be print out
        //    NumericVector x = engine.GetSymbol("x").AsNumeric();

        //    engine.Evaluate("y <- 1:10");
        //    NumericVector y = engine.GetSymbol("y").AsNumeric();

        //    string[] a = engine.Evaluate("'Hi there .NET, from the R engine'").AsCharacter().ToArray();
        //    Console.WriteLine("R answered: '{0}'", a[0]);

        //    Console.WriteLine("Press any key to exit the program");
        //    Console.ReadKey();
        //}
    }
}
