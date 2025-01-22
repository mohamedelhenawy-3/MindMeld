using System.Diagnostics;

namespace Stowatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
             for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());

        }
    }
}
