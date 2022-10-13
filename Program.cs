using System;
namespace coinflip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("////////////////////////");
            Console.WriteLine("Welcome to coinflip game.");
            Console.WriteLine("In this game you'll try to guess computer's pick represented by a coinflip");
            Console.WriteLine("Your score will represent the number of correct guesses in a row");
            Console.WriteLine("////////////////////////////////////////////////////////////////");

            int player_score = 0;
            bool player_win = true;
            while (player_win)
            {
                Console.WriteLine();
                Console.WriteLine("Select heads - type '1'");
                Console.WriteLine("Select tails - type '2'");
                Console.Write("Choose: ");

                char player_choice = Console.ReadKey().KeyChar;
                string player_choice_string = Convert.ToString(player_choice);
                Console.WriteLine();
                if (player_choice_string == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("You have picked heads");
                }
                else if (player_choice_string == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("You have picked tails");
                }

                Random random = new Random();
                int computer_choice = random.Next(1, 3);
                string computer_choice_string = Convert.ToString(computer_choice);

                if (computer_choice_string == "1")
                {
                    Console.WriteLine("Computer have picked heads");
                }
                else if (computer_choice_string == "2")
                {
                    Console.WriteLine("Computer have picked tails");
                }

                if (player_choice_string == computer_choice_string)
                {
                    player_win = true;
                    player_score++;
                    Console.WriteLine("/////////////////////////////////");
                    Console.WriteLine("You have guessed computer's pick!");
                    Console.WriteLine("Current score: " + player_score);
                    Console.WriteLine("/////////////////");

                }
                else
                {
                    player_win = false;
                    Console.WriteLine("////////");
                    Console.WriteLine("You lost");
                    Console.WriteLine("Final score: " + player_score);
                    Console.WriteLine("///////////////");
                }
            }
        }
    }
}