using System.Text;

namespace Print_Without_using_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OpenStanderdOutput => write data binary dirctly to console..
            byte[] data = Encoding.UTF8.GetBytes("Hellow world");

            var openstandard = Console.OpenStandardOutput();
            openstandard.Write(data, 0, data.Length);


            Console.WriteLine("------------ReadKey---------------");

            Console.WriteLine("press any key");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine($"{key.Key}");
        }
    }
}
