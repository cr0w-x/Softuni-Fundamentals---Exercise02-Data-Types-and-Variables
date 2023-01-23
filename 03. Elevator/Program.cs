// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int courses = n / p;

if (n % p != 0)
    courses++;

Console.WriteLine(courses);
