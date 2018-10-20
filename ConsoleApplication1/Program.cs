using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;

            #region Region calculator
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Part 1.");

            Console.ForegroundColor = ConsoleColor.Black;
            int operand1, operand2;
            bool e1 = true;
            int n1;

            while (e1)
            {
                Console.Write("Please enter number 1: ");
                operand1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter number 2: ");
                operand2 = int.Parse(Console.ReadLine());

                int check;
                Console.WriteLine("Please enter number: 1(+)   2(-)   3(*)   4(/)");
                Console.Write("Your choice: ");
                check = int.Parse(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(operand1 + "+" + operand2 + "=" + (operand1 + operand2));
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 2:
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(operand1 + "-" + operand2 + "=" + (operand1 - operand2));
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 3:
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(operand1 + "*" + operand2 + "=" + (operand1 * operand2));
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 4:
                        if (operand2 == 0) Console.WriteLine("Division by zero is impossible!");
                        else
                        {
                            Console.Write("Result: ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(operand1 + "/" + operand2 + "=" + (operand1 / operand2));
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong number!");
                        break;
                }
                Console.WriteLine();

                Console.WriteLine("Do you want to try again? Press(1)-yes   Press(2)-no");
                Console.Write("Your choice: ");
                n1 = int.Parse(Console.ReadLine());
                if (n1 == 1) e1 = true;
                else
                    if (n1 == 2) e1 = false;
            }
            #endregion

            #region Region diapasone
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Part 2.");

            Console.ForegroundColor = ConsoleColor.Black;
            int number;
            bool e2 = true;
            int n2;

            while (e2)
            {
                Console.WriteLine("Please enter number (1-100)");
                number = int.Parse(Console.ReadLine());

                if (number > 100) Console.WriteLine(number + ">" + "100" + "!");
                else
                    if (number < 0) Console.WriteLine(number + "<" + "0" + "!");
                else
                {
                    if ((number >= 0) && (number <= 14))
                    {
                        Console.Write("The diapasone is ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("[0-14]");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if ((number >= 15) && (number <= 35))
                    {
                        Console.Write("The diapasone is ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("[15-35]");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if ((number >= 36) && (number <= 50))
                    {
                        Console.Write("The diapasone is ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("[36-50]");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if ((number >= 51) && (number <= 100))
                    {

                        Console.Write("The diapasone is ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("[51-100]");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine("Do you want to try again? Press(1)-yes   Press(2)-no");
                    n2 = int.Parse(Console.ReadLine());
                    if (n2 == 1) e2 = true;
                    else
                        if (n2 == 2) e2 = false;
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
