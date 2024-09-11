namespace Week3HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double taxRate = .06;

            double oilChange, tireChange, inspection, total, taxAmount, totalWithTax;
            Console.WriteLine("Hello, We are going to calculate the total for your repair shop bill.");
            Console.WriteLine("Enter the total for the oil change: ");
            oilChange = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the total for tires: ");
            tireChange = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the total for the inspection: ");
            inspection = Convert.ToDouble(Console.ReadLine());

            total = (oilChange + tireChange + inspection);
            taxAmount = total * taxRate;
            totalWithTax = total + taxAmount;


            Console.WriteLine("Your Subtotal is: {0} ", total.ToString("C"));
            Console.WriteLine("Your tax is: {0} ", taxAmount.ToString("C"));
            Console.WriteLine("Your Grand Total is: {0} ",  totalWithTax.ToString("C"));

        }
    }
}
