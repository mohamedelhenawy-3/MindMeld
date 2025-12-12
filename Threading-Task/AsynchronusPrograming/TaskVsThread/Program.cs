
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {
        //var th =new Thread(() => Display("thred"));
        //th.Start();

        //Task.Run(() => Display("using task")).Wait();


        //Task<DateTime> task = Task.Run(() => DateTime.Now);
        //Console.WriteLine(task.Result);


        var task = Task.Factory.StartNew(() => RunlongTask(), TaskCreationOptions.LongRunning);
        Console.ReadKey();
        
    }


    static void Display(string msg)
    {

        DisplayThreadInfo(Thread.CurrentThread); Console.WriteLine(msg);

    }

    private static void DisplayThreadInfo(Thread currentThread)
    {
        Console.WriteLine($"id:-{currentThread.ManagedThreadId} --- ispoolthread:-{currentThread.IsThreadPoolThread} -- isbackgrounf{currentThread.IsBackground}.");
     }



    static void RunlongTask()
    {
        Thread.Sleep(300);
        DisplayThreadInfo(Thread.CurrentThread);
        Console.WriteLine("complete");
    }
}