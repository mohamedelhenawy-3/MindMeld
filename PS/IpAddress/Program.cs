using System.Net;
using System.Reflection.Metadata;

namespace IpAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displays the IP Address of the Machine.
            string hostname = string.Empty;
            hostname = Dns.GetHostName();

            Console.WriteLine("Local Machine's Host Name: " + hostname);


            //resolve Hstname to ip 
            IPHostEntry ipEntry = Dns.GetHostEntry(hostname);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0} : {1}", i + 1, addr[i].ToString());
            }

            // Wait for user input
            Console.ReadLine();
        }
    }
}
