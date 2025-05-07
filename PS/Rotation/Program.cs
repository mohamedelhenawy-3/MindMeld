namespace Rotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int d = 2;

            Console.WriteLine("Original Array: " + string.Join(", ", arr));

            LeftRotation(arr, d);  // Perform left rotation

            Console.WriteLine("Left Rotated Array: " + string.Join(", ", arr));
            RightRotate(arr, d);

            Console.WriteLine("Right Rotate : " + string.Join(", ", arr));

     
        }

        public static void RightRotate(int[] arr, int d)
        {

            int n = arr.Length;
            d = d % n;


            int[] temp = new int[d];
            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[n - d + i]; //4,5
                //Console.WriteLine(temp[i] = arr[n - d + i]);
            }





            for (int i = n - d - 1; i >= 0; i--)
                arr[i + d] = arr[i];


            for (int i = 0; i < d; i++)
                arr[i] = temp[i];
        }


        //leftRoation
        public static void LeftRotation(int[]array, int d)
        {
            int n = array.Length;
            d = d % n;
  
            int[] temp = new int[d];


            for(int i = 0; i < d; i++)
            {
                temp[i] = array[i];
            }


            for(int i = d; i < n; i++)
            {
                array[i - d] = array[i];
            }


            for(int i = 0; i < d; i++)
            {
                array[n - d + i] = temp[i] ;
            }




        }
    }
}
