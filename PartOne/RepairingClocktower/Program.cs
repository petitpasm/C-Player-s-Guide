// See https://aka.ms/new-console-template for more information

Console.Write("Please input a number: ");
int value = int.Parse(Console.ReadLine());

for (int i = 0; i < value; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Tick!");
        continue;
    }
    else;
    {
        Console.WriteLine("Tock!");
    }
    
}