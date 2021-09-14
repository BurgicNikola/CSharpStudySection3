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

            // Ternary operator
            // string variable = is condition true ? "yes" : "no"
            // string variable = is condition true ? "yes" : is other condition true ? "yes" : "no"

            stateOfMatter = temperature <= 0 ? "solid" : temperature < 100 ? "liquid" : "gas";

            Console.WriteLine($"State of matter is {stateOfMatter}.");

            Console.Read();
        }
    }
}
