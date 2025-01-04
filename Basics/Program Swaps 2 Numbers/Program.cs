namespace Program_Swaps_2_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = int.Parse(Console.ReadLine());


            int temp;


            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine("nuber 2");
            Console.WriteLine(num2);

        }
    }
}
