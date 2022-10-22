using System;
/*

namespace CSharp_Training
{
    internal class MultiCatch
    {
        static void Main(String[] args)
        {
            int Num1, Num2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Num2 = int.Parse(Console.ReadLine());
                Result = Num1 / Num2;
                Console.WriteLine($"Result:{Result}");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Second number should not be zero");
                Console.WriteLine(de.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Enter only integer numbers");
                Console.WriteLine(fe.Message);
            }

            Console.ReadLine();
        }
    }
}
*/