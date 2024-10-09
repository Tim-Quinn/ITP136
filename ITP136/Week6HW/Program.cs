using static System.Console;


namespace Week6HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 13;
            
            int a = 0, b = 0;

            welcomeStatement();
            magicNumber(secretNumber);
            findArea(a, b);

            double taxRate = localTaxRate();
            WriteLine("The tax rate is: {0}", taxRate);


        }


        static void welcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
        }

        static void magicNumber(int secretNumber)
        {
            WriteLine("the Secret number is: {0}", secretNumber);
        }

        static void findArea(int num1, int num2)
        {
            WriteLine("Please enter number 1: ");
            num1 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter number 2: ");
            num2 = Convert.ToInt32(ReadLine());

            int total = num1 * num2;

            WriteLine("The area is:{0} ", total);

        }

        static double localTaxRate()
        {
            WriteLine("Please enter your tax rate: ");
            int x = Convert.ToInt32(ReadLine());

            return x;
        }
    }
}
