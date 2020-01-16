using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string Calcunit;
            
            Console.WriteLine("\t\t\tSimple Calculator\r");
            Console.WriteLine("\t\t\tXXXXXXXXXXXXXXXXXXXXXXXX\r");

            Console.WriteLine("\t\t\tEnter first number\n");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an operator: (+, -, *, /, %)\n");
            Calcunit = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter second number\n");
            num2 = Double.Parse(Console.ReadLine());

            if (Calcunit == "+")
            {
                Console.Write("\n" + add(num1, num2));
            }
            if (Calcunit == "-")
            {
                Console.Write("\n" + subtract(num1, num2));
            }
            if (Calcunit == "*")
            {
                Console.Write("\n" + multiply(num1, num2));
            }
            if (Calcunit == "/")
            {
                Console.Write("\n" + divide(num1, num2));
            }
            if (Calcunit == "%")
            {
                Console.Write("\n" + modulo(num1, num2));
            }
            Console.ReadKey();

            


            double add(double cijfer1, double cijfer2)
            {
                return cijfer1 + cijfer2;
            }


            double subtract(double cijfer1, double cijfer2)
            {
                return cijfer1 - cijfer2;
            }

            double multiply(double cijfer1, double cijfer2)
            {
                return cijfer1 * cijfer2;
            }

            double divide(double cijfer1, double cijfer2)
            {
                return cijfer1 / cijfer2;
            }

            double modulo(double cijfer1, double cijfer2)
            {
                return cijfer1 % cijfer2;
            }

        }
        

    }
}
