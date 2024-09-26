using static System.Console;

namespace Week4HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int appointmentType, patientType, labsDone, totalCost = 0;



            WriteLine("What type of appointment are you here for?: ");
            WriteLine("1 - Sick Appointment");
            WriteLine("2 - Check-up");
            appointmentType = Convert.ToInt32(Console.ReadLine());

            switch (appointmentType)
            {
                case 1:
                    WriteLine("\nIs this appointment for a child or an adult?: ");
                    WriteLine("1 - Child");
                    WriteLine("2 - Adult");
                    patientType = Convert.ToInt32(Console.ReadLine());

                    if (patientType == 1)
                    {
                        totalCost += 50;
                    }
                    else if (patientType == 2)
                    {
                        totalCost += 75;
                    }
                    else
                    {
                        WriteLine("You entered an invalid option.");
                        break;
                    }

                    WriteLine("\nDid the patient have labs done?: ");
                    WriteLine("1 - Yes");
                    WriteLine("2 - No");
                    labsDone = Convert.ToInt32(Console.ReadLine());

                    if (labsDone == 1)
                    {
                        totalCost += 25;
                    }
                    else if (labsDone == 2)
                    {

                    }
                    else
                    {
                        WriteLine("You entered an invalid option.");
                        break;
                    }

                    WriteLine("\nTotal cost:{0} ", totalCost.ToString("C"));

                    break;

                case 2:
                    WriteLine("\nIs this appointment for a child or an adult?: ");
                    WriteLine("1 - Child");
                    WriteLine("2 - Adult");
                    patientType = Convert.ToInt32(Console.ReadLine());

                    if (patientType == 1)
                    {
                        totalCost += 75;
                    }
                    else if (patientType == 2)
                    {
                        totalCost += 100;
                    }
                    else
                    {
                        WriteLine("You entered an invalid option.");
                        break;
                    }

                    WriteLine("\nTotal cost:{0} ", totalCost.ToString("C"));

                    break;

                default:
                    WriteLine("You entered an invalid option.");
                    break;

            }

        }
    }
}