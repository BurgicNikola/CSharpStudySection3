using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06Challenge
{
    class Program
    {
        /* Create an application with a score, highscore and a highscorePlayer.
         * Create a method which has two parameters, one for the score and one for the playerName.
         * When ever that method is called, it should be checked if the score of the player is higher 
         * than the highscore, if so, "New highscore is + " score" and in another line "New highscore 
         * holder is " + playerName - should be written onto the console, if not 
         * "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
         * Consider which variables are required globally and which ones locally.*/

        static int highscore = 100;
        static string highscorePlayer = "Burgic";

        static void Main(string[] args)
        {
            newPlayer(101, "Nikola");
            newPlayer(55, "Pera");
            newPlayer(187, "Burgic");
            Console.Read();
        }

        public static void newPlayer(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine($"New highscore is {highscore}.");
                Console.WriteLine($"New highscore holder is {highscorePlayer}.");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and is still held by {highscorePlayer}.");
            }
        }
    }
}
