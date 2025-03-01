// See https://aka.ms/new-console-template for more information

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int row = int.Parse(Console.ReadLine());
Console.Write("Target Column? ");
int col = int.Parse(Console.ReadLine());

if ((row < 1 || row > 8) || (col < 1 || col > 8))
{
    Console.WriteLine("Not possible...");
}

Console.WriteLine($"({row}, {col - 1})");
Console.WriteLine($"({row}, {col + 1})");
Console.WriteLine($"({row - 1}, {col})");
Console.WriteLine($"({row + 1}, {col})");

Console.Beep();