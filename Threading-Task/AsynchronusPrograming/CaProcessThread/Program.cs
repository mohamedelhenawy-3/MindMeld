
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {

        Console.WriteLine($"current process {Process.GetCurrentProcess().Id}");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId); //currenthtreadiD
        Console.Read();
    }



}