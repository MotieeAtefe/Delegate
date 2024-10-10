using System;

namespace Delegate
{
    internal class Program
    {
        public delegate double MathOperation(double a, double b);
        static void Main(string[] args)
        {
            MathOperation operation = AddOpration;


            double result = operation(5, 10);
            Console.WriteLine($"Result of Add: {result}"); // خروجی: Result of Add: 15

            // تغییر delegate به متد دیگر
            operation = SubtractOpration;
            result = operation(10, 4);
            Console.WriteLine($"Result of Subtract: {result}");
        }

        static double AddOpration(double a, double b)
        {
            double result = a + b;
            return result;
        }
        static double SubtractOpration(double a, double b)
        {
            double result = a - b;
            return result;
        }
        static double MultyOpration(double a, double b)
        {
            double result = a * b;
            return result;
        }
        double DivideOpration(double a, double b)
        {
            double result = a / b;
            return result;
        }

    }


}
