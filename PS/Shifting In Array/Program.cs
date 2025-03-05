namespace Shifting_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //shifting in insert;
            int[] array = { 1, 2, 3, 4 };
            int insertindex = 2;
            int newValue = 99;

            int[] newArr = new int[array.Length + 1];

            int j = 0;
            for (int i = 0; i <= array.Length; i++)
            {
                if (i == insertindex)
                {
                    newArr[i] = newValue;
                }
                else
                {
                    newArr[i] = array[j++];
                }
            }
            Console.WriteLine(string.Join(" ", newArr));
            Console.WriteLine("--------------------");
            // shifting in delete 
            int[] arr = { 1, 2, 99, 3, 4, 5 };
            int deleteIndex = 2;
            int[] newArray = new int[arr.Length - 1];
         
            for(int i=0,v =0;i< arr.Length; i++)
            {
                if(i != deleteIndex)
                {
                    newArray[v++] = arr[i];
                }
            }
            Console.WriteLine(string.Join(" ", newArray));  // Output: 1 2 3 4 5
        }
    }
}
