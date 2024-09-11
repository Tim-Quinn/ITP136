namespace Week3CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string inputString;

            Console.WriteLine("Enter your name: ");
            inputString = Console.ReadLine();

            Console.WriteLine("Enter your first number: ");
            inputString = Console.ReadLine();
            a = Convert.ToDouble(inputString);

            Console.WriteLine("Enter your second number: ");
            b = Convert.ToDouble(Console.ReadLine());


            double total = a + b;
            Console.WriteLine(total);

        }
    }
}
