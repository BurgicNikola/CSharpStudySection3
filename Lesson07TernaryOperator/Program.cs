using System;

namespace Lesson07TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            int temperature = -5;
            string stateOfMatter;

            if(temperature <= 0)
            {
                stateOfMatter = "solid";
            }
            else if(temperature < 100)
            {
                stateOfMatter = "liquid";
            }
            else
            {
                stateOfMatter = "gas";
            }

            Console.WriteLine($"State of matter is {stateOfMatter}.");

            Console.Read();
        }
    }
}
