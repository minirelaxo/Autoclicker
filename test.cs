using System;
using System.Collections.Generic;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class CalculatorTests
{
    public static void AssertEqual<T>(T expected, T actual, string testName)
    {
        if (EqualityComparer<T>.Default.Equals(expected, actual))
        {
            Console.WriteLine($"PASS: {testName}");
            return;
        }

        throw new Exception($"FAIL: {testName}. Expected '{expected}', but got '{actual}'.");
    }

    public static void RunAll()
    {
        var calculator = new Calculator();

        AssertEqual(5, calculator.Add(2, 3), "Add_ShouldReturnSum");
        AssertEqual(1, calculator.Subtract(3, 2), "Subtract_ShouldReturnDifference");
        AssertEqual(0, calculator.Subtract(5, 5), "Subtract_ShouldReturnZero");

        Console.WriteLine("All tests passed.");
    }
}

public class Program
{
    public static void Main()
    {
        CalculatorTests.RunAll();
    }
}
