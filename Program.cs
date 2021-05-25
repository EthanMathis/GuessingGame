using System;


Main();

void Main()
{
    Guess();
}

void Guess()
{
    Console.WriteLine("I'm thinking of a number between 1 & 100. If you can guess it, I'll say somthing SUPER FUNNY!!");

    int Attempts = Difficulty();

    Console.WriteLine($"Alright, you get {Attempts} guesses. Go!");

    string Guess = Console.ReadLine();
    int GuessNum = int.Parse(Guess);

    Random r = new Random();
    int SecretNumber = r.Next(0, 100);

    int Turn = 1;

    while (Attempts > 0)
    {
        if (GuessNum == SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > THATS IT!!!... something SUPER FUNNY");
            Attempts = 0;
        }
        else if (Attempts == 1 && GuessNum != SecretNumber)
        {
            Console.WriteLine($"You guessed {GuessNum} > WRONG! You're all out of guesses");
            Attempts--;
        }
        else if (GuessNum < SecretNumber)
        {
            Console.Write($"[ Turn {Turn} ]: You guessed {GuessNum} > That's too low... Try again!!   ");
            Attempts--;
            Turn++;
            Console.WriteLine($"(Guesses remaining: {Attempts})");
            Guess = Console.ReadLine();
            GuessNum = int.Parse(Guess);
        }
        else
        {
            Console.Write($"[ Turn {Turn} ]: You guessed {GuessNum} > That's too high... Try again!!   ");
            Attempts--;
            Turn++;
            Console.WriteLine($"(Guesses remaining: {Attempts})");
            Guess = Console.ReadLine();
            GuessNum = int.Parse(Guess);
        }
    }
}

int Difficulty()
{
    Console.WriteLine("Select a difficulty > [  easy  |  medium  |  hard  ]");
    string Choice = Console.ReadLine().ToLower();

    int Diff = 0;

    if (Choice == "easy")
    {
        Diff = 8;
        return Diff;
    }
    else if (Choice == "medium")
    {
        Diff = 6;
        return Diff;
    }
    else if (Choice == "hard")
    {
        Diff = 4;
        return Diff;
    }
    else if (Choice == "cheater")
    {
        Diff = int.MaxValue;
        return Diff;
    }
    else
    {
        Console.WriteLine("Please select a valid difficulty...");
        Difficulty();
    }

    return Diff;
}