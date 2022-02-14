using System;

namespace Demo21_AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();
            int result;

            result = objCalc.Add();
            result = objCalc.Add(10);
            result = objCalc.Add(10, 20, 30, 40);

            // Version 2.
            result = objCalc.Compute(100, 200, Program.Multiply);           // implicitly created delegate variable

            // Version 1.
            ComputeHandler objD = new ComputeHandler(Program.Multiply);     // explicitly created delegate variable
            result = objCalc.Compute(100, 200, objD);

            // Anonymous Method
            ComputeHandler objD2 
                = delegate(int a, int b)
                {
                    return a * b;
                };
            result = objCalc.Compute(100, 200, objD2);

            // LAMBDA Expression
            ComputeHandler objD3
                = (int a, int b) =>             // "=>" i.e., "goes to" operator
                {
                    return a * b;
                };
            result = objCalc.Compute(100, 200, objD3);


            // LAMBDA Expression
            ComputeHandler objD4
                = (a, b) =>             // "=>" i.e., "goes to" operator
                {
                    return a * b;
                };
            result = objCalc.Compute(100, 200, objD4);

            // LAMBDA Expression
            ComputeHandler objD5
                = (a, b) => a * b;
            result = objCalc.Compute(100, 200, objD5);

        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
