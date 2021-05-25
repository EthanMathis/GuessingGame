using System;


Main();

void Main()
{
    Guess();
}

void Guess()
{
    Console.WriteLine("I'm thinking of a number.... Want to guess what it is?");

    string Guess = Console.ReadLine();
    int GuessNum = int.Parse(Guess);

    int SecretNumber = 42;

    if (GuessNum == SecretNumber)
    {
        Console.WriteLine("THATS IT!!! How did you know?");
    }
    else
    {
        Console.WriteLine("Nope. Not even close.");
    }
}