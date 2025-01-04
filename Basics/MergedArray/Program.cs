namespace MergedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //three ways to merged array 
            //1- using concate in Linq
            int[] arra1 = { 1, 2, 34, 5, 6, 6, 7, 7 };
            int[] arra2 = { 100, 200, 300, 3400 };


            Console.WriteLine("-------------Using Linq-------------");
            int[] mergedarray = arra1.Concat(arra2).ToArray();
            foreach(int i in mergedarray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------Using Copy-------------");
            //2- using  Array.Copy
            int[] mergedArray = new int[arra1.Length + arra2.Length];

            // Copy elements from both arrays
            Array.Copy(arra1, 0, mergedArray, 0, arra1.Length);
            Array.Copy(arra2, 0, mergedArray, arra1.Length, arra2.Length);

            Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
        }
    }
}
