using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02IntroToTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "454";
            int parsedValue1;

            bool success = int.TryParse(value1, out parsedValue1);

            if(success)
            {
                Console.WriteLine($"Parsing successful, the number is {parsedValue1}.");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            string value2 = "45.454ee";
            float parsedValue2;

            bool successful = float.TryParse(value2, out parsedValue2);

            if(successful)
            {
                Console.WriteLine($"Parsing successful, the number is {parsedValue2}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            Console.Read();
        }
    }
}
