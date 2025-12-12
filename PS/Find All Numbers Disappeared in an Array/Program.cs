using System.ComponentModel;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];


           var R= FindDisappearedNumbers(nums);
            Console.WriteLine("Missing numbers:");
            foreach (var num in R)
            {
                Console.WriteLine(num);
            }
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> result = new List<int>();


            for (int i = 0; i < nums.Length ; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }




            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }
            return result;

        }


    }
    }
