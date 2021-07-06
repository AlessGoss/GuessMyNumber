using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 99999);
            /* int number = 1; */
            int answer = 0;
            Console.WriteLine("Press \"CTRL + C\" or close the window to exit.");
            while(number != answer)
            {
                start:
                Console.Write("Guess my number! ");
                try {
                answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Type a number.");
                    goto start;
                }
                catch (OverflowException)
                {
                     Console.WriteLine("You can only type a number between -2147483648 and 2147483647.");
                     goto start;
                };
                if (number > answer)
                {
                    Console.WriteLine("Higher.");
                };
                if (number < answer)
                {
                    Console.WriteLine("Lower.");
                };
                if (number == answer)
                {
                    Console.WriteLine("You did it!");
                    Console.WriteLine("Press \"CTRL + C\" or close the window to exit.");
                    number = rnd.Next(1, 99999);
                    answer = 0;
                    goto start;
/*                     Console.WriteLine("Start me again if you want to play!"); */
                    
                    /* playAgain:
                    Console.Write("Play again [y/n]? ");
                    string playAgain = Console.ReadLine();
                    if (playAgain != "y" && playAgain != "n" && playAgain != "Y" && playAgain != "N")
                    {
                        Console.WriteLine("Please decide.");
                        goto playAgain;
                    };
                    if (playAgain == "n" || playAgain == "N")
                    {
                    System.Environment.Exit(0);
                    }
                    else if (playAgain == "y" && playAgain == "Y")
                    {
                    number = rnd.Next(1, 99999);
                    answer = 0;
                    } */
                };
            };
        }
    }
}
