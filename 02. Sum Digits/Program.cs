// See https://aka.ms/new-console-template for more information
int num = int.Parse(Console.ReadLine());
int tempVar;
int sum = 0;

while (num > 0)
{
    tempVar = num % 10;
    sum += tempVar;
    num /= 10;
}

Console.WriteLine(sum); 
