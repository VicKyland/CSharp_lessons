using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculator");
                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter operator (+, -, *, /): ");
                string n = Console.ReadLine();
                // Console.WriteLine($"\"{n}\"");

                while (true)
                {
                    if (n != "+" && n != "-" && n != "*" && n != "/")
                    {
                        Console.Write("Incorrect operator, please try again (+, -, *, /): ");
                        n = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Resualt: ");
                switch (n)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        if (b != 0) { Console.WriteLine(a / b); } 
                        else { Console.WriteLine("Devision by zero"); }
                        break;
                    case null:
                        Console.WriteLine("Unknown error");
                        break;
                }

                Console.Write("\nContinue (y/n): ");
                if (Console.ReadLine() == "n")
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
