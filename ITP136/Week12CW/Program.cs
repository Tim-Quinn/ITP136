using static System.Console;

namespace Week12CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1313, 69000, "Curry", "Stephen", "CEO");

            WriteLine(emp1.EmployeeNumber + " "  + emp1.Salary + " "  + emp1.LastName + " " + emp1.FirstName + " " + emp1.Position);

            int numEmp;

            WriteLine("How many employees do you want to enter? ");
            numEmp = Convert.ToInt32(Console.ReadLine());

            Employee[] empArray = new Employee[numEmp];

            for (int x = 0; x < empArray.Length; x++)
            {
                populateEmployee(ref empArray[x]);

            }

            static void populateEmployee(ref Employee e)
            {
                WriteLine("Enter employee number: ");
                int empNum = Convert.ToInt32(ReadLine());

                WriteLine("Enter employee salary: ");
                double a = Convert.ToDouble(ReadLine());

                WriteLine("Enter employee last name: ");
                string lastName = ReadLine();

                WriteLine("Enter employee first name: ");
                string firstName = ReadLine();

                WriteLine("Enter employee position: ");
                string posit = ReadLine();

                e = new Employee(empNum, a, lastName, firstName, posit);

            }

            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine(empArray[y].EmployeeNumber + " " + empArray[y].Salary + " " + empArray[y].LastName + " " + empArray[y].FirstName + " " + empArray[y].Position);

            }

            WriteLine("Enter the number below that you would like to modify");

            for (int z = 0; z < empArray.Length; z++)
            {
                WriteLine(z + 1 + " " + empArray[z].EmployeeNumber + " " +  empArray[z].LastName + " " + empArray[z].FirstName );
            }

            int selectedEmployee = Convert.ToInt32(ReadLine());

            modifyEmployee(ref empArray[selectedEmployee -1]);

            static void modifyEmployee(ref Employee e)
            {
                WriteLine("what would you like to update?\n 1. Employee Number \n 2. Last Name \n 3. First Name");
                int userInput = Convert.ToInt32(ReadLine());

                if (userInput == 1)
                {
                    WriteLine("What is the new employee number");
                    int newNum = Convert.ToInt32(ReadLine());
                    e.EmployeeNumber = newNum;
                }
                else if (userInput == 2)
                {
                    WriteLine("What is the new last name? ");
                    string newLname = ReadLine();
                    e.LastName = newLname;
                }

                else if (userInput == 3)
                {
                    WriteLine("What is the new first name?");
                    string newFname = ReadLine();
                    e.FirstName = newFname;
                }
                else
                {
                    WriteLine("Invalid input.");
                }

            }

        }
    }
}
