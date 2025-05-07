using System.Collections.Generic;

namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3 };

            Permute(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"The count of even numbers in the array is: {nums[i]}");
            }
            // Display the result
           
        }
      
        public static List<List<int>> Permute(int[] nums)
        {

            List<List<int>> result = new List<List<int>>();
            Backtrack(nums, new List<int>(), new HashSet<int>(), result);
            return result;
        }

        public static void Backtrack(int[] nums, List<int> current, HashSet<int> used, List<List<int>> result)
        {

            if(nums.Length == current.Count)
            {
                result.Add(new List<int>(current));
            }
            for(int i=0;i< nums.Length;i++)
            {
                if (used.Contains(nums[i]))continue;

                current.Add(nums[i]);
                used.Add(nums[i]);
                Console.WriteLine(used.Count);
                Console.WriteLine(current.Count);

                Backtrack(nums, current, used, result);

                current.RemoveAt(current.Count - 1);
                used.Remove(nums[i]);

            }



        }
    }

}
