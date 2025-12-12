
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {
        delay(4);

    }

    static void delay( int g)
    {
        Task.Delay(g).GetAwaiter().OnCompleted(() => { Console.WriteLine($"Aftre delay th output{g}"); });
      
    }

}