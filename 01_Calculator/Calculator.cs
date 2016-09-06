using System;


namespace _01_Calculator
{
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y; 
        }

        public static int AddString(string x, string y)
        {
            return Int32.Parse(x) + Int32.Parse(y);
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Sum(int[] numbers)
        {
            int x = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                x += numbers[i];
            }

            return x;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Power(double x, double y)
        {
            return (int)Math.Pow(x, y);
        }

        public static int Factorial(int x)
        {
            int result = 1;

            if (x == 0 || x == 1)
                return 1;

            for(int i = x; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}