// See https://aka.ms/new-console-template for more information
using Logical_Programs;

Console.WriteLine("Welcome to logical Programs!");
while (true)
{

    Console.WriteLine("\nChoose the Program to be executed :\n1)Fibonacci_Series");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Fibonacci_Series febinocci = new();
            febinocci.FibonacciSeries();
            break;
        default:
            break;
    }
}