
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {

        DisplayThreadData(Thread.CurrentThread, 11);
        SyncCode();

        DisplayThreadData(Thread.CurrentThread, 15);
        Async();


        DisplayThreadData(Thread.CurrentThread, 18);
        Console.ReadKey();

    }

    static void SyncCode()
    {
        Thread.Sleep(4000);
        DisplayThreadData(Thread.CurrentThread, 16);
        Task.Run(() => Console.WriteLine("Sync-----------------------"));

    }


    static void Async()
    {
        DisplayThreadData(Thread.CurrentThread, 24);
        Task.Delay(4000).GetAwaiter().OnCompleted(() =>
        {
            DisplayThreadData(Thread.CurrentThread, 37);

            Console.WriteLine("Async Complete");
        });

    }


    static void DisplayThreadData(Thread cuurent, int Line)
    {
        Console.WriteLine($"Line{Line} - thread {cuurent.ManagedThreadId} ..Pool {cuurent.IsThreadPoolThread}  .backgroud{cuurent.IsBackground} ");
    }
}