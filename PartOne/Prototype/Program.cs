// See https://aka.ms/new-console-template for more information

int numberToGuess = -1;

while (numberToGuess <= 0 || numberToGuess >= 100)
{
    Console.Write("User 1, put a number between 1 and 100: ");
    numberToGuess = int.Parse(Console.ReadLine());
    Console.Clear();
}

bool valueFound = false;
Console.WriteLine("User 2, guess the number");

while (!valueFound)
{
    Console.Write("What is your guess? ");
    int guess = int.Parse(Console.ReadLine());
    if (guess > numberToGuess)
    {
        Console.WriteLine("Too high!");
    }

    if (guess < numberToGuess)
    {
        Console.WriteLine("Too low!");
    }

    if (guess == numberToGuess)
    {
        Console.WriteLine("Well done!");
        valueFound = true;
    }
}
