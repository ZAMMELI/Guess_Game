using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gesser_Gamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // run info app function

            GreetUser(); // ask for user name function


            while (true)
            {
                // set corret number
                //
                // int correctNum = 7;

                // init corret number
                // create a new Random object
                Random rand = new Random();

                int correctNum = rand.Next(1, 10);

                // init guess num
                int guess = 0;

                // ask for num
                Console.WriteLine("Guess a number between 1  and 10");

                while (guess != correctNum)
                {
                    //get users input
                    string input = Console.ReadLine();

                    // make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error msg
                        PrintColorMsg(ConsoleColor.Yellow, "wrong, Please enter an actual number ...");


                        // keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to corect num
                    if (guess != correctNum)
                    {

                        // print error msg
                        PrintColorMsg(ConsoleColor.Red, "wrong number, please try again ...");
                    }
                }
                
                // print win msg
                PrintColorMsg(ConsoleColor.Green, "You Win !!!");

                // ask to play again
                Console.WriteLine("Play Again ? [Y or N] ");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }
        // info app function
        static void GetAppInfo()
        {
            // set app vars
            string appName = "Gesser Game";
            string appVersion = "1.0.0";
            string appAuthor = "Aymen Zam";

            // change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset txt color
            Console.ResetColor();
        }

        // ask user name function
        static void GreetUser()
        {
            // ask user name 
            Console.WriteLine("what is your name");

            // get user name
            string inputName = Console.ReadLine();

            Console.WriteLine("hello {0}, let's play a game ...", inputName);
        }

        // print color msg
        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            // change text color
            Console.ForegroundColor = color;

            // msg
            Console.WriteLine(msg);

            //Reset txt color
            Console.ResetColor();
        }

    }
}
