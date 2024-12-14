namespace FinalProject
{
    public class Program
    {
        public static void Main()
        {

            // This program will give the user 3 types of pizza and 3 sizes to order, then it will display the order at the end of the program.

            try
            {
                // Welcome Message
                Console.WriteLine("Welcome to the Pizza Store!");
                Console.WriteLine("Here is our menu:");

                // Pizza menu array
                string[] menu = { "Pepperoni", "Cheese", "Buffalo Chicken" };

                // Display the menu to the user
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]}");
                }

                // List to store the pizzas the user orders
                List<Pizza> orders = new List<Pizza>();
                bool ordering = true;

                // Loop to handle ordering
                while (ordering)
                {
                    Console.Write("Enter the number of your pizza choice (or 0 to finish): ");
                    string userInput = Console.ReadLine();

                    
                    if (userInput == "0")
                    {
                        ordering = false;
                    }
                    else
                    {
                        // Determine pizza choice based on input
                        string pizzaName = "";
                        if (userInput == "1")
                        {
                            pizzaName = menu[0];
                        }
                        else if (userInput == "2")
                        {
                            pizzaName = menu[1];
                        }
                        else if (userInput == "3")
                        {
                            pizzaName = menu[2];
                        }

                        if (pizzaName != "")
                        {
                            // Ask for the pizza size
                            string sizeInput = "";
                            bool validSize = false;

                            // Loop until valid size is provided
                            while (!validSize)
                            {
                                Console.WriteLine("Select size:");
                                Console.WriteLine("1. Small");
                                Console.WriteLine("2. Medium");
                                Console.WriteLine("3. Large");
                                Console.Write("Enter the number for size: ");
                                sizeInput = Console.ReadLine();

                                // Check for valid size input
                                if (sizeInput == "1")
                                {
                                    sizeInput = "Small";
                                    validSize = true;
                                }
                                else if (sizeInput == "2")
                                {
                                    sizeInput = "Medium";
                                    validSize = true;
                                }
                                else if (sizeInput == "3")
                                {
                                    sizeInput = "Large";
                                    validSize = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid size. Please enter 1 for Small, 2 for Medium, or 3 for Large.");
                                }
                            }
                         
                            PizzaSize pizzaSize = new PizzaSize(pizzaName, sizeInput);

                            // Add the pizza to the order list
                            orders.Add(pizzaSize);
                            Console.WriteLine($"You added a {pizzaSize.Size} {pizzaSize.Name} Pizza to your order.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, please try again.");
                        }
                    }
                }

                // Display the order summary
                Console.WriteLine("\nYour Order Summary:");
                foreach (PizzaSize pizza in orders)
                {
                  
                    Console.WriteLine($"{pizza.Size} {pizza.Name} Pizza");
                }

                Console.WriteLine("Thank you for ordering! Enjoy your meal!");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}