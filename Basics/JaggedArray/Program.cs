namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] Jaggedarray = new int[3][];
            Jaggedarray[0] = new int[2] { 1, 2};
            Jaggedarray[1] = new int[2] { 1,2 };
            Jaggedarray[2] = new int[2] { 1, 2 };
            for (int i = 0; i < Jaggedarray.Length; i++)
            {
                int[] innerArray = Jaggedarray[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.WriteLine(innerArray[a] + " ");
                }
            }

        }
    }
}
