using static System.Console;

namespace Week6CW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            a = 5;

            welcomeMessage();

            for (int k = 0; k < 3; k++)
            {
                a = askNumber();
                b = askNumber();

                addNumber(a, b);
            }

 
        }

        static void welcomeMessage()
        {
            WriteLine("Welcome to my calculator");
        }

        static int askNumber()
        {
            int x;
            WriteLine("Please enter a number: ");
            x = Convert.ToInt32(ReadLine());

            return x; 

        }

        static void addNumber(int num1,int num2)
        {
            int total = num1 + num2;
            WriteLine("Your total is {0} ", total);
        }

        static int addNumber2(int num1, int num2)
        {
            int total = num1 + num2;
            WriteLine("Your total is {0} ", total);

            return total;
        }



    }
}
