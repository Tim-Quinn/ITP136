using static System.Console;


namespace Week12HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many objects would you like to enter?: ");
            int partAmount = Convert.ToInt32(Console.ReadLine());

            Parts[] partArray = new Parts[partAmount];

            for (int x = 0; x < partArray.Length; x++)
            {
                populateParts(ref partArray[x]);

            }

            static void populateParts(ref Parts e)
            {
                WriteLine("Enter part number: ");
                int pNum = Convert.ToInt32(ReadLine());

                WriteLine("Enter part name: ");
                string pName = ReadLine();

                WriteLine("Enter part description ");
                string pDescription = ReadLine();

                WriteLine("Enter part cost: ");
                double pCost = Convert.ToDouble(ReadLine());


                e = new Parts(pNum, pName, pDescription, pCost);

            }


            WriteLine("Enter the number below that you would like to view");

            for (int z = 0; z < partArray.Length; z++)
            {
                WriteLine(z + 1 + " : " + partArray[z].PartNum + " " + partArray[z].PartName);
            }

            int userInput = Convert.ToInt32(Console.ReadLine());

            viewPart(ref partArray[userInput - 1]);

            static void viewPart(ref Parts e)
            {
                WriteLine("\nPart Details:");
                WriteLine("Part Number:{0}", e.PartNum);
                WriteLine("Part Name:{0}", e.PartName);
                WriteLine("Part Description:{0}", e.PartDescription);
                WriteLine("Part Cost:{0}", e.Cost);
            }












        }
    }
}
