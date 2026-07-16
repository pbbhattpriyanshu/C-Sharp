class  GuessingGame
{
    public static void Start()
    {
        Console.WriteLine("Welcome to the Guessing Game!");

        Random random = new Random();
        bool playAgain = true;
        int min = 0;
        int max = 100;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);
            response = "";

            while (guess != number)
            {
                Console.WriteLine("Guess Number b/w " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine(guess + " is to high");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is to low");
                }

                guesses++;
            }

            Console.WriteLine("Number: " + number);
            Console.WriteLine("You WIN");
            Console.WriteLine("Guesses " + guesses);

            Console.Write("Would you like to plag again (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            } else
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for Playing! ..... I Guess");

        Console.ReadKey();
    }
}