using static System.Console;

namespace Week9CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tim", "Timmeh", "Timmer" };

            //WriteLine(names[0]);

            double[] quiz = new double[3];
            double[] test = new double[3];
            double[] assignment = new double[3];

            for(int x = 0; x < names.Length; x++)
            {
                WriteLine("Please enter the quiz average for {0}", names[x]);
                quiz[x] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the test average for {0}", names[x]);
                test[x] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the assignment average for {0}", names[x]);
                assignment[x] = Convert.ToDouble(ReadLine());

            }
            WriteLine("{0,15}{1,20}{2,20}{3,25}", "Name", "Quiz", "Test", "Assignment");
            for (int y = 0; y < names.Length; y++)
            {
                
                WriteLine("{0,15}{1,20}{2,20}{3,25}", names[y], quiz[y], test[y], assignment[y]);
            }

            int i = 0;
            foreach (var name in names)
            {
                

                double avg;

                avg = (quiz[i] + test[i] + assignment[i]) / 3;

                WriteLine("{0,15}{1,15}", name, avg.ToString("F2"));

                i++;
            }

            double m = quiz.Max();

            int p = Array.IndexOf(quiz, m);

            WriteLine("The highest quiz grade belongs to: " + names[p]);

        }
    }
}
