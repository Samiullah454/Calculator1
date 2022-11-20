using System;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double result;
            Console.WriteLine("Enter operations \n" +
                "\n Enter " +
                "\n For subtraction    1 " +
                "\n For addition       2 " +
                "\n For division       3 " +
                "\n For multiplication 4" +
                "\n For square         5 " +
                "\n For square root    6" +
                "\n For power          7" +
                "\n For Modulus        8");
            int opr = Convert.ToInt32(Console.ReadLine());
            if ((opr == 1 || (opr == 2) || (opr == 3) || (opr == 4)))
            {

                Console.WriteLine("Enter 1st number ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (opr == 1)
                {
                    result = num1 - num2;
                    Console.WriteLine("Subtraction is " + result);
                }
                else if (opr == 2)
                {
                    result = num1 + num2;
                    Console.WriteLine("Adittion is " + result);
                }
                else if (opr == 3)
                {
                    if (num2 > 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine(" Division is " + result);

                    }
                    else
                    {
                        Console.WriteLine("Please Enter Number greater than zero");
                    }


                }
                else if (opr == 4)
                {
                    result = num1 * num2;
                    Console.WriteLine("Multiply is " + result);
                }
            }

            else if (opr == 5)
            {
                Console.WriteLine("Enter number");

                num1 = Convert.ToInt32(Console.ReadLine());
                result = num1 * num1;
                Console.WriteLine("Square is " + result);
            }
            else if (opr == 6)
            {
                Console.WriteLine("Enter number");
                num1 = Convert.ToInt32(Console.ReadLine());
                result = Math.Sqrt(num1);
                Console.WriteLine("Sqaure root is " + result);
            }
            else if (opr == 7)
            {
                Console.WriteLine("enter number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter power");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = Math.Pow(num1, num2);
                Console.WriteLine("Power is " + result);
            }
            else if (opr == 8)
            {
                Console.WriteLine("Enter Number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Divisor");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = num1 % num2;
                Console.WriteLine("Modulus is " + result);
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
    }
}
