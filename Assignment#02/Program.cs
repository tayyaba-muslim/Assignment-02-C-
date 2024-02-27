// See https://aka.ms/new-console-template for more information

//1) Write a C# program that takes two numbers as input from the user and performs the following arithmetic operations:
//Addition
//Subtraction
//Multiplication
//Division
//Modulus (Remainder)

Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;
int difference = num1 - num2;
int product = num1 * num2;
int quotient = num1 / num2;
int modulus = num1 % num2;

Console.WriteLine("Addition: " + sum);
Console.WriteLine("Subtraction: " + difference);
Console.WriteLine("Multiplication: " + product);
Console.WriteLine("Division: " + quotient);
Console.WriteLine("Remainder: " + modulus);

//2) Write a C# program to compare two numbers entered by the user and
//   print whether the first number is greater than, less than, or equal to the second number.


Console.WriteLine("Enter the first number:");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num4 = Convert.ToInt32(Console.ReadLine());

if (num3 > num4)
{
    Console.WriteLine("The first number is greater than the second number.");
}
else if (num3 < num4)
{
    Console.WriteLine("The first number is less than the second number.");
}
else
{
    Console.WriteLine("The first number is equal to the second number.");
}

//3) Write a C# program to print the multiplication table of a number entered by the
//    user using a loop (for, while, or do-while)


Console.WriteLine("For Loop");
Console.WriteLine("\n Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication Table of {number}:");

for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} * {i} = {result}");

}

Console.WriteLine("While Loop");
Console.WriteLine("\n Enter a number:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication Table of {number1}:");

int a = 1;
while (a <= 10)
{
    int result = number1 * a;
    Console.WriteLine($"{number1} * {a} = {result}");
    a++;
}

Console.WriteLine("DO while Loop");
Console.WriteLine("\n Enter a number:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication Table of {number2}:");

int b = 1;
do
{
    int result = number2 * b;
    Console.WriteLine($"{number2} * {b} = {result}");
    b++;
} while (b <= 10);

//4) Write a C# program to print a pattern of asterisks (*) in the following format using nested loops:
//*
//**
//***
//****
//*****


Console.WriteLine("Nested Loop");


for (int j = 1; j <= 5; j++)
{
    for (int k = 1; k <= j; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//5) Write a C# program to find the sum of all even numbers between 1 and 100 using loop 
//    control statements (break and continue).

Console.WriteLine("Sum of Even Number");

int sum1 = 0;
for (int z = 1; z <= 100; z++)
{
    if (z % 2 != 0)
    {
        continue;
    }
    sum1 += z;

    if (z > 100)
    {
        break;
    }
    Console.WriteLine(z);
}

Console.WriteLine("The sum of all even numbers between 1 and 100 is: " + sum1);

//6) Write a C# program to reverse a string entered by the user without 
//    using any built-in reverse functions or methods.

Console.WriteLine("Enter a string: ");
string input = Console.ReadLine();

string reversed = "";

for (int y = input.Length - 1; y >= 0; y--)
{
    reversed += input[y];
}

Console.WriteLine("The reversed string is: " + reversed);

//7) Write a C# program to print all the prime numbers between 1 and 
//    100 using a loop and conditional statements.

Console.WriteLine("Prime numbers between 1 and 100");

for (int s = 2; s <= 100; s++)
{
    bool Prime = true;

    for (int t = 2; t < s; t++)
    {
        if (s % t == 0)
        {
            Prime = false;
            break;
        }
    }

    if (Prime)
    {
        Console.WriteLine(s);
    }
}
