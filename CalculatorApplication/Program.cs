using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continued = true, inputError = false, reset = false, start = true;
            string input, inputFunction = "";
            double result = 0, numOne, numTwo;

            do
            {
                Console.Clear();

                if (start)
                {
                    Console.WriteLine("Insert a number");
                    input = Console.ReadLine();

                    while (!double.TryParse(input, out numOne))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input, try a number!");
                        input = Console.ReadLine();
                    }

                    start = false;
                }
                else
                    numOne = result;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Number: " + numOne);
                    Console.WriteLine();
                    Console.WriteLine("Choose function [+] [-] [*] [/] [P]ower [F]actorial [C]ancel");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                        case "P":
                        case "p":
                            inputFunction = input;
                            inputError = false;
                            break;

                        case "F":
                        case "f":
                            result = Calculator.Factorial(numOne);
                            inputError = false;
                            reset = true;
                            break;

                        case "C":
                        case "c":
                            result = 0;
                            reset = true;
                            start = true;
                            break;

                        default:
                            inputError = true;
                            break;
                    }
                }
                while (inputError);

                if (!reset)
                {
                    Console.Clear();
                    Console.Write(numOne + " " + inputFunction + " ");
                    input = Console.ReadLine();

                    while (!double.TryParse(input, out numTwo))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input, try a number!");
                        input = Console.ReadLine();
                    }

                    switch (inputFunction)
                    {
                        case "+":
                            result = Calculator.Add(numOne, numTwo);
                            break;

                        case "-":
                            result = Calculator.Subtract(numOne, numTwo);
                            break;

                        case "*":
                            result = Calculator.Multiply(numOne, numTwo);
                            break;

                        case "/":
                            result = Calculator.Divide(numOne, numTwo);
                            break;

                        case "P":
                        case "p":
                            result = Calculator.Power(numOne, numTwo);
                            break;
                    }
                }
                

            }
            while (continued);
        }
    }
}
