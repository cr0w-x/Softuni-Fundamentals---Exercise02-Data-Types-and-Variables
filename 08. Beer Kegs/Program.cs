// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
double volumeOfBiggestKeg = 0;
string nameOfBiggestKeg = string.Empty;

for (int i = 0; i < n; i++)
{
    string inputName = Console.ReadLine();
    float inputRadius = float.Parse(Console.ReadLine());
    int inputHeight = int.Parse(Console.ReadLine());

    double tempVar = Math.PI * (inputRadius * inputRadius) * inputHeight;

    if (tempVar >= volumeOfBiggestKeg)
    {
        volumeOfBiggestKeg = tempVar;
        nameOfBiggestKeg = inputName;
    }

}

Console.WriteLine(nameOfBiggestKeg);