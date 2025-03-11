namespace Closest_Num_To_Largest_Num_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 1, 14, 9, 10, 12 };
            int largest = int.MinValue;
            int closest = int.MinValue;



            foreach ( int num in numbers)
            {
                if(num > largest)
                {
                    largest = num;
                }
            }

            int minDiff = int.MaxValue;

            foreach( int num in numbers)
            {
                if(num != largest)
                {
                    int diff = largest - num;
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        closest = num;
                    }
                }
               
            }
            Console.WriteLine($"Largest: {largest}");
            Console.WriteLine($"Closest to largest: {closest}");
        }


    }
}
