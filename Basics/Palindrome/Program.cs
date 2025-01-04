namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseNumber(222);
        }

        public static int ReverseNumber(int num)
        {
            int reversed = 0;
            int temp = num;
            Console.WriteLine(temp);
            while (num != 0)
            {
                int remainder = num % 10; // Get the last digit
                reversed = reversed * 10 + remainder; // Append it to reversed
                num = num / 10; // Remove the last digit
            }
          
            if (temp == reversed)
            {
                return reversed;
            }

            return 0;


        }
    }
}
