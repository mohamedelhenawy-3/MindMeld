namespace CheckOddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.WriteLine("Enter Number");
            i = int.Parse(Console.ReadLine());
            if(i % 2 == 0)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }
        }
    }
}
