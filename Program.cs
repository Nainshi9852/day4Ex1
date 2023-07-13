using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks in the pre-exam:");
            int preMarks = Convert.ToInt32(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.WriteLine("Enter marks in the final exam:");
                int finalMarks = Convert.ToInt32(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Result: Selected");
                }
                else
                {
                    Console.WriteLine("Result: Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Result: Fail in Pre");
            }
            Console.ReadKey();
        }
    }
}
