using System;

namespace Week3CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> even = new List<int>();
           List<int> odd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }

            }

            foreach (int i in even)
            {
                if (i == even.First())
                {
                  
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write(i);
            }
            Console.WriteLine();

            foreach (int i in odd)
            {
                if (i == odd.First())
                {

                }
                else
                {
                    Console.Write(" ");
                }
                    Console.Write(i);
                
            }


           
            


            
        }
    }
}