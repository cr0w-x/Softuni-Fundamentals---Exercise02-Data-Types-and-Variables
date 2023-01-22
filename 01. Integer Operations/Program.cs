// See https://aka.ms/new-console-template for more information
int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numThree = int.Parse(Console.ReadLine());
int numFour = int.Parse(Console.ReadLine());

int total = 0;

total = numOne + numTwo;
total /= numThree;
total *= numFour;

Console.WriteLine(total);
