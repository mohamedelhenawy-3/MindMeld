namespace Odd_Numbers_within_a_Range_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //odd numbers from rang of numbers


            int start;
            int end;

            Console.WriteLine("Enter the first :-");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end :-");
            end = int.Parse(Console.ReadLine());

            for(int i = start; i < end; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
