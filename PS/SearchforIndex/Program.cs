namespace SearchforIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // 1 3 5 6 7 =>2;

        public static int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;
            int mid;


         while(left < right)
            {
                mid = (left + right) / 2; //5  target 2
                if(target == nums[mid])
                {
                    return mid;
                }else if(target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }




            return 0;
        }
    }
}
