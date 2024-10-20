namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // collect user name, user's address, user's date of travel
            string userName, userAddress, travelDate;
            
            Console.WriteLine("What is your name: ");
            userName = Console.ReadLine();

            Console.WriteLine("What is your address: ");
            userAddress = Console.ReadLine();

            Console.WriteLine("What is the date of travel?");
            travelDate = Console.ReadLine();

            double bagCharge = collectBagData();
            double seatCharge = collectSeatData();

            createReceipts(bagCharge, seatCharge, userName, travelDate);



            static double collectBagData()
            {
                Console.WriteLine("How many bags are you traveling with?");
                int bagCount = Convert.ToInt32(Console.ReadLine());

                if (bagCount > 0)
                {
                    return bagCount * 25;
                }
                else
                {
                    return 0;
                }

            }

    
            static double collectSeatData()
            {
                Console.WriteLine("How many seats do you need?");
                int seatCount = Convert.ToInt32(Console.ReadLine());

                if (seatCount > 0)
                {
                    return seatCount * 30;
                }
                else
                {
                    return 0;
                }
            }

            static void createReceipts(double bagCharge, double seatCharge, string userName, string travelDate)
            {
                const double taxRate = .05;

                double total = (bagCharge + seatCharge);
                double taxAmount = total * taxRate;
                double totalWithTax = total + taxAmount;


                Console.WriteLine();
                Console.WriteLine("Receipt");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Name: {0}", userName);
                Console.WriteLine("Travel Date: {0}", travelDate);
                Console.WriteLine();
                Console.WriteLine("Baggage Charge: {0}", bagCharge.ToString("C"));
                Console.WriteLine("Seat Charge: {0}", seatCharge.ToString("C"));
                Console.WriteLine("--------------------------");
                Console.WriteLine("Subtotal: {0}", total.ToString("C"));
                Console.WriteLine("Tax (5%): {0}", taxAmount.ToString("C"));
                Console.WriteLine("Total: {0}", totalWithTax.ToString("C"));
            }
        }
    }
}
