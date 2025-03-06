// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int AskForNumber(string text)
{
    Console.WriteLine(text);
    int answer = int.Parse(Console.ReadLine());
    return answer;
}

int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
Console.WriteLine(result);
int answer2;
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine(text);
        answer2 = int.Parse(Console.ReadLine());
        if (answer2 > min && answer2 < max)
        {
            break;
        }
    }

    return answer2;
}

int resutl2 = AskForNumberInRange("sure?", 1, 320);
Console.WriteLine(resutl2);