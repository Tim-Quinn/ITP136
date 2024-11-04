namespace Week10HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food();
            Food food2 = new Food();


            food1.FoodID = 1337;
            food1.Name = "Blueberry";
            food1.Description = "Fruit";
            food1.Cost = 2.00;

            food2.FoodID = 4200;
            food2.Name = "Cabbage";
            food2.Description = "Vegetable";
            food2.Cost = 3.00;


            Console.WriteLine("{0,0}{1,15}{2,20}{3,15}", "Food ID", "Food Name", "Food Description", "Food Cost");

            Console.WriteLine("{0,0}{1,18}{2,15}{3,15:C2}", food1.FoodID, food1.Name, food1.Description, food1.Cost);
            Console.WriteLine("{0,0}{1,18}{2,15}{3,15:C2}", food2.FoodID, food2.Name, food2.Description, food2.Cost);
        }
    }
}
