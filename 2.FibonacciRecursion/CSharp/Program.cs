using System;
using CSharp;

class Program
{
    static void Main(string[] args)
    {
        var fib = new Fibonacci();

        Console.WriteLine("Calculating Fibonacci");
        Console.WriteLine($"-7: {fib.Calculate(-7)}");
        Console.WriteLine($"-1: {fib.Calculate(-1)}");
        Console.WriteLine($"0: {fib.Calculate(0)}");
        Console.WriteLine($"1: {fib.Calculate(1)}");
        Console.WriteLine($"2: {fib.Calculate(2)}");
        Console.WriteLine($"4: {fib.Calculate(4)}");
        Console.WriteLine($"7: {fib.Calculate(7)}");
    }
}
