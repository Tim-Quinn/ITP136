using static System.Console;

namespace Week10CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(); 
            Employee emp2 = new Employee();

            emp1.EmployeeId = 1234;
            emp1.lastName = "Quinn";
            emp1.firstName = "Tim";

            emp2.EmployeeId = 4567;
            emp2.lastName = "Curry";
            emp2.firstName = "Stephen";

            WriteLine("{0,10}{1,20}{2,20}", emp1.EmployeeId, emp1.lastName, emp1.firstName);
            WriteLine("{0,10}{1,20}{2,20}", emp2.EmployeeId, emp2.lastName, emp2.firstName);

            emp1.lastName = "iHateThis";

            WriteLine("{0,10}{1,20}{2,20}", emp1.EmployeeId, emp1.lastName, emp1.firstName);

            WriteLine("Enter employee id: ");
            emp2.EmployeeId = Convert.ToInt32(ReadLine());

            WriteLine("Enter Employee Last name: ");
            emp2.lastName = ReadLine();

            WriteLine("Enter Employee First name: ");
            emp2.firstName = ReadLine();


        }
    }
}
