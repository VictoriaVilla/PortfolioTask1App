using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixLibrary;

namespace PortfolioTask1App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Hello!\nPlease enter Two Numbers\na: ");
            do
            {
                a = MixLibrary.Read.ReadInteger();
                a = MixLibrary.Validate.ValidateInt(a);
                MixLibrary.Validate.ValidationIntMessage(a);
            } while (a < 0);

            Console.WriteLine("b: ");
            do
            {
                b = MixLibrary.Read.ReadInteger();
                b = MixLibrary.Validate.ValidateInt(b);
                MixLibrary.Validate.ValidationIntMessage(b);
            } while (b < 0);

            Console.WriteLine("This is the result of the sum of a and b: " + MixLibrary.Calculation.Add(a, b));
            Console.WriteLine("This is the result of the substraction of a and b: " + MixLibrary.Calculation.Sub(a, b));
            Console.ReadKey();
        }
    }
}
