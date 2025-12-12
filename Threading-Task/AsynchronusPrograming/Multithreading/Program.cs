
using Multithreading;
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {



        Thread.CurrentThread.Name = "MainThread";
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine($"bacggroundthread{Thread.CurrentThread.IsBackground}");


        var wallet = new Wallet("essam", 1772);
        Thread t1 = new Thread(wallet.transactionrandom);

        t1.Name = "t1";
        Console.WriteLine($"bacggroundthread{t1.IsBackground}");
        Console.WriteLine($"After declare T1 {t1.Name}  state is {t1.ThreadState}");

        t1.Start();
        t1.Join();// t1 swill finsih after that you can use t2;
        Console.WriteLine($"After Start T1 {t1.Name}  state is {t1.ThreadState}");




        Thread t3 = new Thread(new ThreadStart(wallet.transactionrandom));
        t3.Name = "t3";
        t3.Start();


    }



}