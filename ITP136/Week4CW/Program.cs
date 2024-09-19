using static System.Console;

namespace Week4CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 2;
            int second = 3;

            if(first == second)
            {
                WriteLine("The numbers are equal");
            }
            else
            {
                WriteLine("The numbers are not equal");
                if(first > second)
                {
                    WriteLine("The first number is higher than the second number");
                }
                else
                {
                    WriteLine("The first number is lower than the second number");
                }
            }

            char ch = 'x';
            
            if(ch == 'a' || ch == 'A')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'o' || ch == 'O')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                WriteLine("Vowel");
            }
            else
            {
                WriteLine("Constant");
            }

            int option, a, b, total;

            WriteLine("Enter your first number: ");
            a = Convert.ToInt32(ReadLine());

            WriteLine("Enter your second number: ");
            b = Convert.ToInt32(ReadLine());

            WriteLine("1 - Add, 2 - Subtract, 3 - Multiply, 4 - Divide");
            option = Convert.ToInt32(ReadLine());

            switch(option)
            {
                case 1:
                    total = a + b;
                    WriteLine("The numbers added are {0}", total);
                    break;
                case 2:
                    total = a - b;
                    WriteLine("The numbers subtracted are {0}", total);
                    break;
                case 3:
                    total = a * b;
                    WriteLine("The numbers multiplied are {0}", total);
                    break;
                case 4:
                    total = a / b;
                    WriteLine("The numbers divided are {0}", total);
                    break;
                
                default:
                    WriteLine("Invalid number");
                    break;
            }

        }
    }
}
