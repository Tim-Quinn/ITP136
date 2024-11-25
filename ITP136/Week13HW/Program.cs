using static System.Console;
using System.Diagnostics;

namespace Week13HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my program");

            List<Student> studentList = new List<Student>();
            List<Teacher> teachList = new List<Teacher>();

            Console.WriteLine("How many students do you want to enter?: ");
            int inputStudent = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < inputStudent; x++)
            {
                WriteLine("Enter the ID number: ");
                int empNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter the full student name: ");
                string fn = ReadLine();

                WriteLine("Enter the address: ");
                string addy = ReadLine();

                WriteLine("Enter the major");
                string major = ReadLine();

                WriteLine("Enter the advisor:");
                string advisor = ReadLine();

                studentList.Add(new Student(empNum, fn, addy, major, advisor));
            }

            Console.WriteLine("How many teachers do you want to enter?: ");
            int inputTeacher = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < inputTeacher; x++)
            {
                WriteLine("Enter the ID number: ");
                int idNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter the full employee name: ");
                string fn = ReadLine();

                WriteLine("Enter the teachers address: ");
                string addy = ReadLine();

                WriteLine("Enter the salary: ");
                double sal = Convert.ToDouble(Console.ReadLine());

                WriteLine("Enter the teachers years of service: ");
                int yos = Convert.ToInt32(Console.ReadLine());

                teachList.Add(new Teacher(idNum, fn, addy, sal, yos ));
            }

            WriteLine("STUDENTS");
            WriteLine("ID Number | Full Name        | Address       | Major          | Advisor");
            WriteLine("---------------------------------------------------------------");

            foreach (Student stud in studentList)
            {
                WriteLine("{0,-10}|{1,-18}|{2,-15}|{3,-15}|{4,-15}", stud.IDNumber, stud.FullName,  stud.Addy, stud.Major, stud.Advisor);
            }

            WriteLine();

            WriteLine("TEACHERS");
            WriteLine("ID Number | Full Name        | Address       | Salary        | Years of Service");
            WriteLine("---------------------------------------------------------------");



            foreach (Teacher teach in teachList)
            {
                WriteLine("{0,-10}|{1,-18}|{2,-15}|{3,-15}|{4,-15}", teach.IDNumber, teach.FullName, teach.Addy, teach.Salary, teach.YearsOfService);
            }

        }
    }
}
