
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        //var th = new Thread(ExecptionnWithTrycatch);
        //th.Start();
        //th.Join();

        //try
        //{
        //   var th = new Thread(Execptionn);
        //    th.Start();
        //    th.Join();
        //}
        //catch
        //{
        //    Console.WriteLine("eXACPTION US TRUE");
        //}


        //using task
        try
        {
            await Task.Run(Execptionn);

        }
        catch
        {
            Console.WriteLine("cATCH");
        }
    }

    static void Execptionn()
    {
        throw new NullReferenceException();
    }
    static void ExecptionnWithTrycatch()
    {
        try
        {
            throw new NullReferenceException();

        }
        catch
        {
            Console.WriteLine("eXACPTION US TRUE");

        }
    }
}