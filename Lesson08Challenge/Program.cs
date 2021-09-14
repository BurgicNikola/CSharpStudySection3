using System;

namespace Lesson08Challenge
{
    /* We have studied ternary operators and their usage so here is a small challenge for you. 
     * Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.
     * If the input value is not an integer value, it should print to the console "Not a valid Temperature".
     * And if the input value is the valid integer then it should work as mentioned below.
     * If input temperature value is <=15 it should write "it is too cold here" to the console.
     * If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
     * If the input temperature value is > 28 it should write "it is hot here" to the console.
     * Make sure to use ternary operators and not if statements to check for the three conditions, 
     * however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.*/
    class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.Write("What is the temperature in the room? ");
            string input = Console.ReadLine();
            bool isString = int.TryParse(input, out temperature);

            /*if(!isString)
            {
                Console.WriteLine("Not a valid temperature");
            }
            else if(isString)
            {
                if(temperature <= 15)
                {
                    Console.WriteLine("It is too cold here");
                }
                else if(temperature >= 16 && temperature <= 28)
                {
                    Console.WriteLine("It is ok");
                }
                else
                {
                    Console.WriteLine("It is hot here");
                }
            }*/

            string response = !isString ? "Not a valid temperature" : temperature <= 15 ? "It is too cold here" : temperature >= 16 && temperature <= 28 ? "It is ok" : "It is hot here";
            Console.WriteLine(response);
            Console.Read();


        }
    }
}
