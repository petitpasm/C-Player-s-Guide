// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter the base of your triangle:");
float baseTriangle = float.Parse(Console.ReadLine());
Console.WriteLine("Now, the height:");
float height = float.Parse(Console.ReadLine());

float area = (baseTriangle * height) / 2;

Console.WriteLine("The area of your triangle is " + area);