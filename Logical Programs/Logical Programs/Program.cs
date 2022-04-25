// See https://aka.ms/new-console-template for more information
using Logical_Programs;

Console.WriteLine("Welcome to logical Programs!");
while (true)
{

    Console.WriteLine("\nChoose the Program to be executed :\n1)Fibonacci_Series\n2)PerfectNumber\n3)PrimeNumber\n4)ReverseNumber\n5)StopwatchProgram");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Fibonacci_Series febinocci = new();
            febinocci.FibonacciSeries();
            break;
        case 2:
            PerfectNumber perfect = new();
            perfect.perfectnumber();
            break;
        case 3:
            PrimeNumber prime = new();
            prime.primenumber();
            break;
        case 4:
            ReverseNumber reverse = new();
            reverse.reversenumber();
            break;
        case 5:
            StopwatchProgram stopwatch = new();
            stopwatch.stopWatch();
            break;
        default:
            break;
    }
}