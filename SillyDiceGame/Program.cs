namespace SillyDiceGame
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
                int score = 0;
                for(int i = 0;i < 2; i++)
                {
                    do
                    {
                        int roll = random.Next(1, 7);
                        score += roll;
                        if (score > 21)
                        {
                            Console.WriteLine("You have lost.");
                        }
                        else
                        {
                            Console.Write("\n\nWould you like to draw again? (y/n): ");
                            //redo = Console.ReadKey().KeyChar;
                        }
                        redo = Console.ReadKey().KeyChar;
                    } while (redo == 'y'|| redo == 'Y');
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
            Console.WriteLine("Goodbye!");
        }
    }
}
