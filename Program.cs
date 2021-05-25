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
    Console.WriteLine($"You guessed {GuessNum}");
}