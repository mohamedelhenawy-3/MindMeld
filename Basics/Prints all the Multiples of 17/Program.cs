namespace Prints_all_the_Multiples_of_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"num {i} : {i * 17}");
            }
        }
    }
}
