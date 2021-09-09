using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the temperature outside? ");
            int temperature = int.Parse(Console.ReadLine());

            if(temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }
            else if(temperature < 20)
            {
                Console.WriteLine("It's mild");
            }
            else
            {
                Console.WriteLine("It is warm");
            }

            Console.ReadKey();

        }
    }
}
