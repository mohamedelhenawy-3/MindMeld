namespace sum__all_digits_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, r;
            int sum = 0;
            Console.WriteLine("Enter number:-");
            num= int.Parse(Console.ReadLine());


            while( num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum += r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();

        }
    }
}
