namespace ClosestNumToLargeBySorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 4, 10, 7, 2 };

            int closest = FindClosestNumToLarg(array);
            Console.WriteLine($"Closest to largest: {closest}");
        }
        public static int FindClosestNumToLarg(int[] array)
        {
            int n = array.Length;
            BuubleSort(array);
            Console.WriteLine("Sortedaee");
            foreach (int i in array)
            {
               
                Console.WriteLine(i);
            }
            Console.WriteLine($"closest{array[n-2]}");

            return array[n - 2];
        }


        public static void BuubleSort(int[] array)
        {
            int n = array.Length;


            for(int i = 0; i < n ; i++)
            {
                for(int j = i + 1; j < n ; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
