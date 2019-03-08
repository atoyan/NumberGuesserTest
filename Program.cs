using System;






namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change Color to Blue
            setConsoleColor();

            //Show App Info 
            getAppInfo();

            //Greet User 
            greetUser();
            Random rand = new Random();


            int CorrectNumber = rand.Next(1, 11);

            //Guess
            int guess = 0;

            Console.WriteLine("Guess a number, between 1 and 10");


            Boolean guessed = false;
            while (guessed == false)
            {
                if (!int.TryParse(Console.ReadLine(), out guess)) {
                    guessed = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, You Must Enter A Number");
                    Console.ResetColor();
                    //Keep Going
                    continue;
                }

                if (guess != CorrectNumber)
                {
                    guessed = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, Guess Again");
                    Console.ResetColor();
                }
                else
                {
                    guessed = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You guessed correctly!, the number is {0}", CorrectNumber);
                    Console.ResetColor();
                    System.Environment.Exit(1);
                }
            }






        }

        //Change Console Color to Blue and Text To White
        public static void setConsoleColor()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

        }

        public static void getAppInfo() {
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andranik Atoyan";

            Console.WriteLine("{0}: Version {1} By {2} ", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        public static void greetUser()
        {
            Console.WriteLine("What's your name");

            string input = Console.ReadLine();

            Console.WriteLine("hello {0} let's play a game", input);
        }
    
    }
}
