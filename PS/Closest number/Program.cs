namespace Closest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = { 1, 10, 7, 4, 5, 6 };
            int target = 3;


            int closest = numbers.OrderBy(x => Math.Abs(x - target)).First();

            Console.WriteLine(closest);
        }
    }
}
