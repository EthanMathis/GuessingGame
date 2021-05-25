using System;


Main();

void Main()
{
    Guess();
}

void Guess()
{
    Console.WriteLine("I'm thinking of a number between 1 & 100. If you can guess it in 4 tries, I'll say somthing funny.");

    string Guess = Console.ReadLine();
    int GuessNum = int.Parse(Guess);

    Random r = new Random();
    int SecretNumber = r.Next(0, 100);

    int Attempts = 4;

    while (Attempts > 0)
    {
        if (GuessNum == SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > THATS IT!!! something funny....");
            Attempts = 0;
        }
        else if (Attempts == 1 && GuessNum != SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > WRONG! You're all out of guesses");
            Attempts--;
        }
        else if (GuessNum < SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > That's too low... Try again!");
            Attempts--;
            Console.WriteLine($"Number of guesses left: {Attempts}");
            Guess = Console.ReadLine();
            GuessNum = int.Parse(Guess);
        }
        else
        {
            Console.WriteLine($"You guessed {GuessNum} > That's too high... Try again!");
            Attempts--;
            Console.WriteLine($"Number of guesses left: {Attempts}");
            Guess = Console.ReadLine();
            GuessNum = int.Parse(Guess);
        }
    }
}