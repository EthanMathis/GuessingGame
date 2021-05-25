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

    int SecretNumber = 42;

    int Attempts = 0;

    while (Attempts < 4)
    {
        if (GuessNum == SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > THATS IT!!! How did you know?");
            Attempts = 4;
        }
        else if (Attempts == 3 && GuessNum != SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > WRONG! You're all out of guesses");
            Attempts++;
        }
        else
        {
            Console.WriteLine($"You guessed {GuessNum} > Not quite... Try again");
            Guess = Console.ReadLine();
            GuessNum = int.Parse(Guess);
            Attempts++;
        }
    }

    // for (int i = 0; i < 3; i++)
    // {
    //     if (GuessNum == SecretNumber)
    //     {
    //         Console.WriteLine("THATS IT!!! How did you know?");
    //         i = 3;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Nope. Try again");
    //         Guess = Console.ReadLine();
    //         GuessNum = int.Parse(Guess);
    //     }
    // }

}