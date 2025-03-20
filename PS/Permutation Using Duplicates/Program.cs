using System;
using System.Collections.Generic;

namespace Permutation_Using_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            List<List<int>> permutations = Permute(nums);

            Console.WriteLine("All Permutations:");
            foreach (var perm in permutations)
            {
                Console.WriteLine(string.Join(", ", perm));
            }
        }

        public static List<List<int>> Permute(int[] nums)
        {
            Array.Sort(nums); // Sort to handle duplicates correctly
            List<List<int>> result = new List<List<int>>();
            Backtrack(nums, new List<int>(), new bool[nums.Length], result);
         
            return result;
        }

        public static void Backtrack(int[] nums, List<int> current, bool[] used, List<List<int>> result)
        {
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return; // Stop further recursion
            }

            for (int i = 0; i < nums.Length; i++) // Fix loop to use index
            {
                if (used[i]) continue;  // Skip already used elements

                // Skip duplicate numbers if the previous identical number was not used
                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;

                // Include current number
                current.Add(nums[i]);
                used[i] = true;

                Console.WriteLine($"Current : {current[^1]}"); // Fix index issue
                Console.WriteLine($"Used[{i}] : {used[i]}");

                // Explore further
                Backtrack(nums, current, used, result);

                // Backtrack
                Console.WriteLine($"Removing: {current[^1]}");
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
