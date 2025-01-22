namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create an instance of the Program class
            Program program = new Program();

            // Call the RemoveValue method to remove odd values
            int countOfEvens = program.RemoveValue(nums, 3);

            // Display the result
            Console.WriteLine($"The count of even numbers in the array is: {countOfEvens}");
        }
        public int RemoveValue(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int k = 0;
            

            for (int i=0; i<nums.Length;i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }





            return k;

        }
    }

}
