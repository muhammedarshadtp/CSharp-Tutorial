using System;
namespace Rock
{
    class Paper
    {
        public static void Scisser()
        {

            Random random = new Random();
            bool playAgain = true;
            string? player;

            while (playAgain)
            {
                player = "";
               
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                   Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player?.ToUpper();

                }
                Console.WriteLine("You chose is: " + player);
            }
            Console.ReadKey();

        }
    }
}