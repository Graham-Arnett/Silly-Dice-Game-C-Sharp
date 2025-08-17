﻿namespace SillyDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silly dice game app" +
                "\nRoll two dice and add the numbers together, if you get above 21 or below the bot's roll you lose");
            char redo;
            Random random = new Random();
            do
            {
                bool gameEnd = false;
                int score = 0;
                for(int i = 0;i < 2; i++)
                {
                    //int score = 0;
                    do
                    {
                        int roll = random.Next(1, 7);
                        score += roll;
                        Console.WriteLine($"\nYour roll is: {roll}, and your total score is: {score}");
                        if (score > 21)
                        {
                            Console.WriteLine("\n\nYou have lost.");
                            
                        }
                        else if (score == 21)
                        {
                            Console.WriteLine("You win!");
                            
                        }
                        else
                        {
                            Console.Write("\n\nWould you like to draw again? (y/n): ");
                            //redo = Console.ReadKey().KeyChar;
                        }
                        redo = Console.ReadKey().KeyChar;
                        if(redo != 'y' || redo != 'Y')
                        {
                            Console.WriteLine("\n\n");
                            gameEnd = true;
                        }
                        //if (redo == 'y')
                        //{
                        //    //Console.WriteLine("\n\nThanks for playing!");
                        //    gameEnd = true;
                        //}
                    } while (redo == 'y'|| redo == 'Y' || gameEnd == false);
                    score = 0;
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye!");
        }
    }
}
