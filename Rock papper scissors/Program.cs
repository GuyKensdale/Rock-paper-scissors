using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_papper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int pcScore = 0;

            Console.WriteLine("Welcome to rock paper scissors!");


            while (playerScore != 3 && pcScore != 3) 
            {
                Console.WriteLine("player score - " + playerScore);
                Console.WriteLine("Enemy score - " + pcScore + "\n");
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors");
                string playerChoice = Console.ReadLine();


                int pcChoice = random.Next(0, 3);
                if( pcChoice == 0)
                {

                    Console.WriteLine("Enemy chose rock.\n");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("tie\n");
                            break;
                        case "p":
                            Console.WriteLine("Player wins\n");
                            playerScore++;
                            break;
                            default:
                            Console.WriteLine("You lost this round!\n");
                            pcScore++; 
                            break;

                    }
                }
                else if( pcChoice == 1)
                {

                    Console.WriteLine("Enemy chose paper.\n");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You lost this round!\n");
                            pcScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie\n");
                            break;
                        default:
                            Console.WriteLine("Player wins\n");
                            playerScore++;
                            break;

                    }
                }
                else
                {

                    Console.WriteLine("Enemy chose scissors.\n");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You won this round!\n");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Bad luck, the enemy won this round!\n");
                            pcScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!\n");
                            break;

                    }
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You win!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You lost! Better luck next time.");
                Console.ReadKey();
            }
        }
    }
}
