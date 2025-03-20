using System.Runtime;

namespace Permutations
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 6, 8, 7, 5, 3, 2, 1 };
            NextPermutiation(nums);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        //[4, 6, 8, 7, 5, 3, 2, 1] ==> start with n-2 i will get index 1
        //after that i need to find next large nunm that 6 i will start from last element 

        static void NextPermutiation(int[] array)
        {
            int n = array.Length;
            int i = n - 2;


            while (i >= 0 && array[i] > array[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = n - 1;
                while (array[j] > array[i])
                {
                    j--; //> index 4.
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            //reverse right part
            Reversre(array, i + 1, n - 1);
        }
        static void Reversre(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }
    }
   

     
}
