namespace Maximum_Subarray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = maxsubarray(nums);
            Console.WriteLine($"Maximum Subarray Sum: {result}");
        }

        public static int maxsubarray(int[] nums)
        {
            int maxsofar = nums[0]; //rreach max
            int maxEnd = nums[0]; // using for iterate every step


            for(int i =1; i < nums.Length; i++)
            {
                if(maxEnd + nums[i] > nums[i])
                {
                    maxEnd = maxEnd + nums[i];
                }
                else
                {
                    maxEnd = nums[i];
                }


                // checking acbout final sum;

                if(maxEnd > maxsofar)
                {
                    maxsofar = maxEnd;
                }



            }
            return maxsofar;
        }
    }
}
