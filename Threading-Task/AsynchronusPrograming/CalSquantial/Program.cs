
using CalSquantial;
using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main()
    {

        Wallet al = new Wallet("mohamed", 80);
        al.transactionrandom();
        Console.WriteLine(al);

    }



}