using System.Diagnostics;

namespace Find_Subsequence_of_Length_K_With_the_Largest_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           bool c= CheckOfThree(21);
            Console.WriteLine(c);


            Console.WriteLine(string.Join(", ", Powerofnum(12)));  // Output: 9, 3
            Console.WriteLine(string.Join(", ", Powerofnum(28)));  // Output: 27, 1
            Console.WriteLine(string.Join(", ", Powerofnum(91)));  // Output: 81, 9, 1
            Console.WriteLine(string.Join(", ", Powerofnum(7)));   // Outpu
        }

        public static bool CheckOfThree(int n)
        {
            while(n> 0)
            {
                if(n %3 == 2)
                {
                    return false;
                }
                n /= 3;
            }
            return true;
        }
        public static List<int> Powerofnum(int n)
        {
            List<int> powers = new List<int>();
            List<int> Result = new List<int>();

            int power = 1;

            while(power <= n)
            {
                powers.Add(power);
                power *= 3;
            }
            //[1,3,9]


            for(int i= powers.Count-1; i >= 0; i--)
            {
                if (n >= powers[i])
                {
                    Result.Add(powers[i]);
                    n -= powers[i];
                }
            }
            return Result;
        }
    }
}
