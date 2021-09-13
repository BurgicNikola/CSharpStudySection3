using System;


namespace Lesson04Challenge

    /* Create a user Login System, where the user can first register and then Log in. The Program 
     * should check if the user has entered the correct username and password, when logging in 
     * (so the same ones that he used when registering).
     * As we haven't covered storing data yet, just create the program in a way, that registering 
     * and logging in, happen in the same execution of it.
     * Use If statements and User Input and Methods to solve the challenge.*/
{
    class Program
    {
        static string username;
        static string password;
        static string loginUsername;
        static string loginPassword;

        static void Main(string[] args)
        {
            Login();
            Register();
            CheckCredentials();
        }

        public static void Login()
        {
            Console.WriteLine("*REGISTRATION*");
            Console.Write("Choose your username: ");
            username = Console.ReadLine();
            Console.Write("Choose your password: ");
            password = Console.ReadLine();
        }

        public static void Register()
        {
            Console.WriteLine("*LOG IN*");
            Console.Write("Enter your username: ");
            loginUsername = Console.ReadLine();
            Console.Write("Enter your password: ");
            loginPassword = Console.ReadLine();
        }

        public static void CheckCredentials()
        {
            if (username.Equals(loginUsername) && password.Equals(loginPassword))
            {
                Console.WriteLine("You are now logged in.");
            }
            else if (username.Equals(loginUsername) && !password.Equals(loginPassword))
            {
                Console.WriteLine("Wrong password.");
            }
            else if (!username.Equals(loginUsername) && password.Equals(loginPassword))
            {
                Console.WriteLine("Wrong username.");
            }
            else
            {
                Console.WriteLine("Wrong credentials.");
            }

            Console.Read();
        }
    }
}
