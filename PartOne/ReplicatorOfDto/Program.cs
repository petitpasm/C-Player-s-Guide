// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int[] firstArray = new int[5];
int[] secondArray = new int[5];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write("Please enter a number: ");
    firstArray[i] = int.Parse(Console.ReadLine());
    secondArray[i] = firstArray[i];
}

Array.ForEach(firstArray, Console.WriteLine);
Array.ForEach(secondArray, Console.WriteLine);