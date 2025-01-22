using System.Diagnostics;

namespace Longest_Consecutive_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arry = { 1, 4, 6, 7, 8, 5, 100 };

            Console.WriteLine(returnlength(arry));
        }



        static int returnlength(int[] array)
        {
            int k = 0;
            Array.Sort(array);
            for(int x = 0; x < array.Length; x++)
            {
                Console.WriteLine(array[x]);
            }

            for(int i = 0; i < array.Length-1; i++)
            {
                if ( )
                {
                    k++;
                }
            }


            return k;
        }
    }
}
