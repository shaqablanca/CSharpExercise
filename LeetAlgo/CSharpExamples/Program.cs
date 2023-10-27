using System;

class Program
{
    static void Main()
    {
        long result = func4(15, 3); // Replace these arguments with the values you want to test.
        Console.WriteLine("Result: " + result);
    }

    private static long func4(long a, long b)
    {
        long x;

        if (Math.Abs(a) >= Math.Abs(b))
        {
            x = Math.Sign(a) * func4(Math.Abs(a) - Math.Abs(b), Math.Abs(b));
            Console.WriteLine(Math.Sign(a));
        }
        else
        {
            x = 1;
        }
        return x;
    }
}
