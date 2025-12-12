
using Deadlock;
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {

        var wallet1 = new Wallet("mohamed", 50,1);
        var wallet2 = new Wallet("reema", 50,2);

        Console.WriteLine("Before transaction");
        Console.WriteLine(wallet1);
        Console.WriteLine(wallet2);
        Console.WriteLine("aFTER tRANSACTION");

        var tran = new transfermanager(wallet1, wallet2, 5);
        var tran2 = new transfermanager(wallet2, wallet1, 16);



        var t1 = new Thread(tran.Transfer);
        t1.Name = "T1";
        var t2 = new Thread(tran2.Transfer);
        t2.Name = "T2";


        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();

        Console.WriteLine(wallet1);
        Console.WriteLine(wallet2);

    }



}