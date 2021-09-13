using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 25;

            // We are switching through various cases for variable age and telling the program what to do in each of those cases
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party!");
                    break;
                case 25:
                    Console.WriteLine("Go ahead!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            // Same thing using if else
            if(age == 15)
            {
                Console.WriteLine("Too young to party!");
            }
            else if(age == 25)
            {
                Console.WriteLine("Go ahead!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            // Example with string variable

            string username = "root";

            switch (username)
            {
                case "Nikola":
                    Console.WriteLine("Your username is Nikola");
                    break;
                case "root":
                    Console.WriteLine("Your username is root");
                    break;
                default:
                    Console.WriteLine("Unknown username");
                    break;
            }

            Console.Read();
        }
    }
}
