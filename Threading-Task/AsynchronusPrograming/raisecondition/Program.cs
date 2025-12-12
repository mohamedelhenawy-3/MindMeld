
using raisecondition;
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {

        var wallet = new Wallet("mohamed", 50);



        var t1 = new Thread(()=>wallet.Depit(40));
        var t2 = new Thread(() => wallet.Depit(30));
     
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine(wallet);

    }



}