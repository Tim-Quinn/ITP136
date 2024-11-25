using static System.Console;

namespace Week13CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Salary> salList = new List<Salary>();
            List<Commission> comList = new List<Commission>();

            salList.Add(new Salary(1313, "Tim Quinn", 85000));
            salList.Add(new Salary(1337, "Jdog Perkins", 84000));

            comList.Add(new Commission(2024, "Yikes", 25000));
            comList.Add(new Commission(1994, "This is confusing", 38000));

            foreach (Commission co in comList)
            {
                WriteLine(co.EmployeeNum + " " + co.FullName + " " + co.Sales);
            }

            foreach (Salary sal in salList)
            {
                WriteLine(sal.EmployeeNum + " " + sal.FullName + " " + sal.SalaryAmount);
            }

            WriteLine("How many employees do you want to add?: ");
            int inputAnswer = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < inputAnswer; x++)
            {
                WriteLine("Enter the employee number: ");
                int empNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter the full employee name: ");
                string fn = ReadLine();

                WriteLine("Enter the salary: ");
                double sal = Convert.ToDouble(Console.ReadLine());

                salList.Add(new Salary(empNum, fn, sal));
            }

            foreach (Salary sal in salList)
            {
                WriteLine(sal.EmployeeNum + " " + sal.FullName + " " + sal.SalaryAmount);
            }

        }
    }
}
