namespace _4Sums
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            int target = 0;

            var result = FourSum(nums, target);

            Console.WriteLine("4-Sum Results:");
            foreach (var quadruplet in result)
            {
                Console.WriteLine($"[{string.Join(", ", quadruplet)}]");
            }
        }

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            // Sort the array to facilitate duplicate handling
            Array.Sort(nums);

            // Call the backtracking method
            Back(nums, target, 0, new List<int>(), result);

            return result;
        }

        public static void Back(int[] nums, int target, int start, List<int> current, IList<IList<int>> result)
        {
            // Base case: If we have exactly 4 numbers and their sum is target, add them to the result
            if (current.Count == 4)
            {
                if (target == 0) // Ensure the sum matches the target
                {
                    result.Add(new List<int>(current));
                }
                return; // Stop further recursion
            }

            // Iterate through the array
            for (int i = start; i < nums.Length; i++)
            {
                int num = nums[i];

                // Skip duplicates
                if (i > start && num == nums[i - 1]) continue;

                // Add the current number to the list
                current.Add(num);

                // Recur with reduced target and the next starting index
                Back(nums, target - num, i + 1, current, result);

                // Remove the last number to backtrack
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
