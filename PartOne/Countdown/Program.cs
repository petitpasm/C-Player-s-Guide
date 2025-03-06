// See https://aka.ms/new-console-template for more information



int Countdown(int i)
{
    if (i == 0) return 0;
    Console.WriteLine(i);
    return Countdown(i - 1);
}
Console.Write("Enter a value: ");
var ask = int.Parse(Console.ReadLine());
Console.WriteLine(Countdown(ask));