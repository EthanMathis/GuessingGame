using System;


Main();

void Main()
{
    Guess();
}

void Guess()
{
    Console.WriteLine("Guess what number I'm thinking of. You get 4 tries.");

    string Guess = Console.ReadLine();
    int GuessNum = int.Parse(Guess);

    Random r = new Random();
    int SecretNumber = r.Next(0, 100);

    int Attempts = 4;

    while (Attempts > 0)
    {
        if (GuessNum == SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > THATS IT!!! How did you know?");
            Attempts = 0;
        }
        else if (Attempts == 1 && GuessNum != SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > WRONG! You're all out of guesses");
            Attempts--;
        }
        else
        {
            Console.WriteLine($"You guessed {GuessNum} > Not quite... Try again");
            Attempts--;
            Console.WriteLine($"Number of guesses left: {Attempts}");
            Guess = Console.ReadLine();
            GuessNum = int.Parse(Guess);
        }
    }
}