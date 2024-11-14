using System;

public static class FunctionComposition
{
    // Define a method to compose two functions
    public static Func<TInput, TResult> Compose<TInput, TIntermediate, TResult>(
        this Func<TIntermediate, TResult> f, Func<TInput, TIntermediate> g)
    {
        return x => f(g(x));
    }
}

class Program
{
    static void Main()
    {
        // Define two functions
        Func<int, int> addOne = x => x + 1;
        Func<int, int> square = x => x * x;

        // Compose the functions
        Func<int, int> addOneThenSquare = square.Compose(addOne);

        // Test the composed function
        int result = addOneThenSquare(4); // First add one to 4, then square the result: (4 + 1)^2 = 25
        Console.WriteLine(result); // Output: 25
    }
}

