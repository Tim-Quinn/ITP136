using static System.Console;

namespace Week11CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberArray = { "Gretsky", "Jordan", "Ruth" };

            try
            {
                WriteLine("Enter the element you want to see: ");
                int elementNumber = Convert.ToInt32(ReadLine());

                WriteLine(numberArray[elementNumber]);
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e);
            }
            
            int num1, num2;

            double total;

            WriteLine("Please enter number 1: ");
            num1 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter number 2: ");
            num2 = Convert.ToInt32(ReadLine());


            try
            {
                total = num1 / num2;
                WriteLine("Your total is {0}", total);

            }
            catch(DivideByZeroException e)
            {
                WriteLine("Cannot divide by zero");
            }
            

        }
    }
}
