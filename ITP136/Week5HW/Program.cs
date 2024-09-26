namespace Week5HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber, endNumber;

            Console.WriteLine("Enter a starting number: ");
            startNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an end number: ");
            endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Starting number is: {0} ", startNumber);
            Console.WriteLine("End number is: {0} ", endNumber);

            for (int counter = startNumber; counter <= endNumber; counter++)
            {
                Console.WriteLine("Counter:{0} ", counter);
            }

            
            
        }
    }
}
