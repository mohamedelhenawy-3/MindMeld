using System;
using System.Collections.Generic;

namespace Permutation_lists
{
    public class Program
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
           
            List<List<int>> result = new List<List<int>>();
            Backtrack(nums, new List<int>(), new HashSet<int>(), result);
            return result;
        }

        public static void Backtrack(int[] nums, List<int> current, HashSet<int> used, List<List<int>> result)
        {
            
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current)); 
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used.Contains(nums[i])) continue;

            
                current.Add(nums[i]);
                used.Add(nums[i]);

                Backtrack(nums, current, used, result);

                // Undo choice (Backtrack)
                current.RemoveAt(current.Count - 1);   //it will stop untill i = 2 and we remove third num..
                used.Remove(nums[i]);
            }
        }
    }
}

