using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Week14CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, welcome to the ice cream shop!");

            char moreItems = 'y';

            int counter = 0;

            List<Orders> orders = new List<Orders>();

            while(moreItems == 'y')
            {
                WriteLine("Lets get the items for item {0}", counter + 1);

                collectOrder(ref orders);
                counter++;

                WriteLine("Would you like to continue? y/n");
                moreItems = Convert.ToChar(ReadLine());

            }

            WriteLine("{0,-15}{1,-20}{2,-20}", "Name", "Flavor", "Topping");

            foreach (Orders o in orders)
            {
                WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderFlavor, o.OrderTopping);

            }



        }

        public static void collectOrder(ref List<Orders> o)
        {
            var listOfFlavors = File.ReadLines("Flavors.csv").Select(line => new Flavors(line)).ToList();
            var listOfToppings = File.ReadLines("Toppings.csv").Select(line => new Toppings(line)).ToList();

            WriteLine("Name this order");
            string name = ReadLine();

            WriteLine("Which flavor would you like?");
            foreach (Flavors f in listOfFlavors)
            {
                WriteLine($"{f.FlavorID}\t{f.FlavorName}");
            }

            int a = Convert.ToInt32(ReadLine());
            string flavor = listOfFlavors[a-1].FlavorName;

            WriteLine("Which topping would you like?");

            foreach (Toppings t in listOfToppings)
            {
                WriteLine($"{t.ToppingID}\t{t.ToppingName}");
            }

            int b = Convert.ToInt32(ReadLine());
            string topping = listOfToppings[b - 1].ToppingName;

            o.Add(new Orders(name, flavor, topping));
        }


    }
}
