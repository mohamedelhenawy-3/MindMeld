
namespace Splitter
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            LeftRotate(arr, 2, 7);
            foreach(int m in arr)
            {
                Console.WriteLine(m);
            }
        }


        public static void LeftRotate(int[]arr,int k,int n)
        {
            for(int  i = 0; i < k; i++)
            {
                LeftRotateByOne(arr, n);
            }
        }

        private static void LeftRotateByOne(int[] arr, int n)
        {
            int temp = arr[0];
            for( int i=0; i< n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[n - 1] = temp;

        }
    }
}
