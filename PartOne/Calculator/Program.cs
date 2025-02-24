// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello! Welcome to a simple calculator.");

Console.WriteLine("Please enter first number:");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter the operator: (+ - * /)");
string symbol = Console.ReadLine();

Console.WriteLine("Please enter second number:");
float b = float.Parse(Console.ReadLine());

float result;

switch (symbol)
{
    case "+":
        result = add(a, b);
        Console.WriteLine("The result is " + result);
        break;
    case "-":
        result = substract(a, b);
        Console.WriteLine("The result is " + result);
        break;
    case "*":
        result = multiply(a, b);
        Console.WriteLine("The result is " + result);
        break;
    case "/":
        result = divide(a, b);
        Console.WriteLine("The result is " + result);
        break;
    default:
        Console.WriteLine("Please enter a correct operator.");
        break;
}







float add(float a, float b)
{
    return a + b;
}

float substract(float a, float b)
{
    return a - b;
}

float multiply(float a, float b)
{
    return a * b;
}

float divide(float a, float b)
{
    if (a == 0 || b == 0)
    {
        Console.WriteLine("Can't divide by 0!");
    }

    return a / b;
}