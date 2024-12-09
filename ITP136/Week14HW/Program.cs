using static System.Console;

namespace Week14HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, welcome to the cake shop!");

            char moreItems = 'y';

            int counter = 0;

            List<CakeOrders> orders = new List<CakeOrders>();

            while (moreItems == 'y')
            {
                WriteLine("Lets get the items for item {0}", counter + 1);

                collectOrder(ref orders);
                counter++;

                WriteLine("Would you like to continue? y/n");
                moreItems = Convert.ToChar(ReadLine());

            }

            WriteLine("{0,-15}{1,-20}{2,-20}", "Name", "Design", "Decorations");

            foreach (CakeOrders o in orders)
            {
                WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderFlavor, o.OrderTopping);

            }



        }

        public static void collectOrder(ref List<CakeOrders> o)
        {
            var listOfDesign = File.ReadLines("Design.csv").Select(line => new Design(line)).ToList();
            var listOfDecorations = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();

            WriteLine("Name this order");
            string name = ReadLine();

            WriteLine("Which cake design would you like?");
            foreach (Design d in listOfDesign)
            {
                WriteLine($"{d.DesignID}\t{d.DesignName}");
            }

            int a = Convert.ToInt32(ReadLine());
            string design = listOfDesign[a - 1].DesignName;

            WriteLine("What cake decorations would you like?");

            foreach (Decorations dec in listOfDecorations)
            {
                WriteLine($"{dec.DecorationsID}\t{dec.DecorationsName}");
            }

            int b = Convert.ToInt32(ReadLine());
            string decorations = listOfDecorations[b - 1].DecorationsName;

            o.Add(new CakeOrders(name, design, decorations));
        }


    }
}

