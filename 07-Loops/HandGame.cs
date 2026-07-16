class HandGame
{
    public static void Start()
    {
        Console.WriteLine("Welcome to the Rock, Paper, Scissors Game!");

        Random random = new Random();
        bool playAgain = true;
        string response;

        while (playAgain)
        {
            Console.WriteLine();

            Console.Write("Enter the Match of Series you want to play (3,5 or 7): ");
            int match = Convert.ToInt32(Console.ReadLine());
            int playerPoint = 0;
            int computerPoint = 0;

            for (int i = 1; i <= match; i++)
            {
                string player = "";
                string computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.WriteLine();
                    Console.Write("Enter ROCK, PAPER or SCISSOR: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                bool playerWins = false;
                bool computerWins = false;

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (computer == "PAPER")
                        {
                            computerWins = true;
                        }
                        else
                        {
                            playerWins = true;
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            playerWins = true;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else
                        {
                            computerWins = true;
                        }
                        break;
                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            computerWins = true;
                        }
                        else if (computer == "PAPER")
                        {
                            playerWins = true;
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        break;
                }

                if (playerWins)
                {
                    playerPoint++;
                    Console.WriteLine("Player wins this match!");
                }
                else if (computerWins)
                {
                    computerPoint++;
                    Console.WriteLine("Computer wins this match!");
                }

                Console.WriteLine("Current Scoreboard -> Player: " + playerPoint + " | Computer: " + computerPoint);
            }

            Console.WriteLine();
            Console.WriteLine("Series Complete!");
            Console.WriteLine("Final Scoreboard -> Player: " + playerPoint + " | Computer: " + computerPoint);

            if (playerPoint > computerPoint)
            {
                Console.WriteLine("Final Winner: Player");
            }
            else if (computerPoint > playerPoint)
            {
                Console.WriteLine("Final Winner: Computer");
            }
            else
            {
                Console.WriteLine("Final Result: It's a draw!");
            }

            Console.WriteLine();

            Console.Write("Would you like to play again? (yes/no): ");
            response = Console.ReadLine();
            response = response.ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadKey();
    }
}