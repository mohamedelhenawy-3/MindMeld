namespace _3Sum_Closest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



       public  static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = int.MaxValue;
            int n = nums.Length;



            for(int i=0; i < n; i++)
            {
                int left = i + 1;
                int right = n-1;

                while (left < right)
                {
                    int currentsum = nums[i] + nums[left] + nums[right];

                    if(Math.Abs(currentsum-target) < Math.Abs(closestSum-target))
                    {
                        closestSum = currentsum; 
                    }
                    if (currentsum < target)
                    {
                        left++; // Increase the sum
                    }
                    else if (currentsum > target)
                    {
                        right--; // Decrease the sum
                    }
                    else
                    {
                        // If the sum is exactly equal to the target, return it
                        return currentsum;
                    }
                }
            }
            return closestSum;
        }
    }
}
