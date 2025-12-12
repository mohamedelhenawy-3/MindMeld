using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Start");
        var result = await CalculateSumAsync();
        Console.WriteLine(result);
        Console.WriteLine("until it return result");
    }

    public static async Task<int> CalculateSumAsync()
    {
        int a = await GetNumberAsync();
        int b = await GetNumberAsync();

        return a + b;
    }

    public static async Task<int> GetNumberAsync()
    {
        await Task.Delay(1000); // simulate long work
        return 10;
    }
}
