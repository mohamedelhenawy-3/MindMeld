namespace Prints_the_Sum_of_all_the_Multiples_of_3_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int sum = 0;
            for(int i=0; i<= 100; i++)
            {
                x = i % 3;
                y = i % 5;
                if(x ==0 || y == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
