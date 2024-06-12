using System;

public static class FuncExtensions
{
    public static Func<T2, T1, R> Swap<T1, T2, R>(this Func<T1, T2, R> f)
        => (t2, t1) => f(t1, t2);
}

class Program
{
    static void Main()
    {
        Func<int, int, int> divide = (x, y) => x / y;
        var divideBy = divide.Swap();

        int result = divideBy(2, 6); // Internally calls divide(6, 2)
        Console.WriteLine(result); // Output: 3
    }
}




