// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());

foreach (char firstNum in Enumerable.Range('a', (char)n))
{
    foreach (char secondNum in Enumerable.Range('a', (char)n))
    {
        foreach (char thirdNum in Enumerable.Range('a', (char)n))
        {
            Console.Write(firstNum);
            Console.Write(secondNum);
            Console.Write(thirdNum);
            Console.WriteLine();
        }

    }

}
