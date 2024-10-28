namespace Week9HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carMake = new string[5];
            string[] carModel = new string[5];
            double[] carCost = new double[5];

            for (int i = 0; i < carMake.Length; i++)
            {
                Console.WriteLine("Please enter the make of the car: ");
                carMake[i] = Console.ReadLine();

            }

            Console.WriteLine();

            for (int i = 0; i < carModel.Length; i++)
            {
                Console.WriteLine("Please enter the model of the car: ");
                carModel[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < carCost.Length; i++)
            {
                Console.WriteLine("Please enter the cost of the car: ");
                carCost[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("{0,15}{1,20}{2,20}", "Make", "Model", "Cost");

            for (int i = 0; i < carMake.Length; i++)
            {
                Console.WriteLine("{0,15}{1,20}{2,20}", carMake[i], carModel[i], carCost[i]);
            }

            double highestCost = carCost.Max();

            int highestCarCostArrayIndex = Array.IndexOf(carCost, highestCost);

            Console.WriteLine();
            Console.WriteLine("The most expensive car is:\nMake: {0}\nModel: {1}\nCost: {2}", carMake[highestCarCostArrayIndex], carModel[highestCarCostArrayIndex], carCost[highestCarCostArrayIndex]);

        }
        
    }
}
