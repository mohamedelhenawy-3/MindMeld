
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;

public class Program
{
    public static void Main()
    {




        Task<int> task = Task.Run(() => CountPrimesInRange(1, 2_000_000));


        var awai = task.GetAwaiter();
        awai.OnCompleted(() =>
        {
            Console.WriteLine(awai.GetResult());
        }
        ); 
        Console.WriteLine(awai);
    }

    static int CountPrimesInRange(int start, int end)
    {
        int count = 0;

        // Prime numbers must start at 2
        if (start < 2)
            start = 2;

        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number))
                count++;
        }

        return count;
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false; // even numbers not prime

        int limit = (int)Math.Sqrt(n);
        for (int i = 3; i <= limit; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }


}