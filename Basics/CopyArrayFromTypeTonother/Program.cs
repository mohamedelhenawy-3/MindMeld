using System.Drawing;

namespace CopyArrayFromTypeTonother
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int lenthofcopy;
            Console.WriteLine("Enter size of first array");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Enter first array elemwnt");
            for(int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter size of Second array");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[m];



          


            Console.WriteLine("enter lenth of copy");
            lenthofcopy = Convert.ToInt32(Console.ReadLine());


             Array.Copy(arr1,arr2,lenthofcopy);


            Console.WriteLine("New Array With The Specified Section of Elements " +
                     "in the First Array");
            foreach (int value in arr2)
            {
                Console.WriteLine(value);
            }
            Console.Read();









        }
    }
}
