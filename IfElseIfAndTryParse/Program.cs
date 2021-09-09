using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03IfElseIfAndTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the temperature outside? ");
            int temperature;
            bool success= int.TryParse(Console.ReadLine(), out temperature);

            if(!success)
            {
                Console.WriteLine("Please restart and type in only numbers.");
            } 
            else if (temperature < 10)
            {
                Console.WriteLine("It is cold");
            }
            else if (temperature < 20)
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
