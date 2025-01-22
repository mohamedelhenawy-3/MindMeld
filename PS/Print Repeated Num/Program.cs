namespace Print_Repeated_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] array = { 0, 1, 2, 3, 4, 5, 4 };   //0 1 2 3 4 5 
            int sum1 = 0;
            int sum2 = 0;
            int n = array.Length;
            Console.WriteLine($" length of arr{n}");
            int number = 0;
             
            for(int i =0; i < n-1 ; i++) //6
            {
                sum1 += i;  // 0+1+2+3+4+5  
                Console.WriteLine($"i:{i}");
                Console.WriteLine($"sum1:{sum1}");
            }

            //int result = (n * (n + 1)) / 2;//)


            Console.WriteLine($"sum1:{sum1}");
            for (int i = 0; i < n; i++) //6
            {
                sum2 += array[i];  // 0+1+2+3+4+5  
                Console.WriteLine($"i:{i}");
                Console.WriteLine($"sum2:{sum2}");
            }

            Console.WriteLine($"sum2:{sum2}");
            number = sum2 - sum1;


            Console.WriteLine(number);

        }
    }
}
