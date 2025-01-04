namespace ReverseNum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReverseNumber(1445));
        }
        public static int  ReverseNumber(int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                int remainder = num % 10; // Get the last digit
                reversed = reversed * 10 + remainder; // Append it to reversed
                num = num / 10; // Remove the last digit
            }
            return reversed;
        }
    }
}
