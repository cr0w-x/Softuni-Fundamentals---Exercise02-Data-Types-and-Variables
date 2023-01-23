// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int totalWater = 0;

for (int i = 0; i < n; i++)
{
    int quantitiesOfWater = int.Parse(Console.ReadLine());

    if (totalWater + quantitiesOfWater > 255)
    {
        Console.WriteLine("Insufficient capacity!");
    }

    else
    {
        totalWater+= quantitiesOfWater;
    }

}

Console.WriteLine(totalWater);
