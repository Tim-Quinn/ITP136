using System.Linq.Expressions;
using static System.Console;

namespace Week11HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2;
            decimal result;

            try
            {
                WriteLine("Enter the first number: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                WriteLine("Enter the second number: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                WriteLine("Choose a math operation: ");
                WriteLine("1 - Addition");
                WriteLine("2 - Multiplication");
                WriteLine("3 - Subtraction");
                WriteLine("4 - Division");
                int mathChoice = Convert.ToInt32(Console.ReadLine());

                switch (mathChoice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 * num2;
                        break;
                    case 3:
                        result = num1 - num2;
                        break;
                    case 4:
                        try
                        {
                            result = num1 / num2;
                        }
                        catch (DivideByZeroException)
                        {
                            WriteLine("Cannot divide by zero.");
                            return;
                        }
                        break;
                    default:
                        WriteLine("Invalid choice. Please choose a number between 1-4.");
                        return;
                }

                WriteLine("The result is:{0}", result);
            }

            catch (FormatException)
            {
                WriteLine("Error: Invalid input. Please enter a valid number.");
            }

                }


        }

        }
   

