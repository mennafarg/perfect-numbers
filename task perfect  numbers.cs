// See https://aka.ms/new-console-template for more information
using System;


static bool IsPerfect(int number)
{
    int sum = 0;
    for (int i =1; i< number; i++)
    {
        if (number % i == 0) sum = sum + i;


    }
    if (sum == number) return true;
    return false;
}

Console.WriteLine("hello,please enrer first number: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("hello,please enrer second number: ");
int second = int.Parse(Console.ReadLine());
for (int i = first; i <= second; i++)
{
    if (IsPerfect(i)) Console.WriteLine("{0}" ,i);
}


