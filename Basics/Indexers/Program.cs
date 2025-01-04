namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IpAddress ip = new IpAddress(111, 222, 333, 444);
            var fggg = ip[0];
            Console.WriteLine(ip.add);
        }
    }
}
