// See https://aka.ms/new-console-template for more information
int numberOfLines = int.Parse(Console.ReadLine());
char[] symbolArray = new char[numberOfLines];

for (int i = 0; i < symbolArray.Length; i++)
{
    symbolArray[i] = char.Parse(Console.ReadLine());
}

int totalSum = 0;

for (int i = 0; i < symbolArray.Length; i++)
{
    totalSum += (int)symbolArray[i];
}

Console.WriteLine($"The sum equals: {totalSum}");
