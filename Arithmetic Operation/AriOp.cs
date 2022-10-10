using System;

namespace VSCode // Note: actual namespace depends on the project name.
{
    internal class AriOp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operators");

            //Simple Arithmetic Operators

            //Addition
            Console.WriteLine("This is addition");
            int addi = 100 + 120;
            Console.WriteLine(addi);

            //Subtraction
            Console.WriteLine("This is Subtraction");
            int subt = 100 - 47;
            Console.WriteLine(subt);

            //Multiplication
            Console.WriteLine("This is Multiplication");
            int multi = 100 * 47;
            Console.WriteLine(multi);

            //Division
            Console.WriteLine("This is Division");
            int divi = 100 / 47;
            Console.WriteLine(divi);

            //Modulo
            Console.WriteLine("This is Modulo");
            int mod = 100 % 47;
            Console.WriteLine(mod);

            
        }
    }
}