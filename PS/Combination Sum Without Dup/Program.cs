namespace Combination_Sum_Without_Dup
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



        public static  IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
           IList<IList<int >> result = new List<IList<int>>();

            Array.Sort(candidates);
            BackTracting(candidates, target, 0, new List<int>(), result);

            return result;

        }

        public static void BackTracting(int[] candidates, int target,int start, List<int> current, IList<IList<int>> result)
        {
           
            if (target == 0)
            {
                result.Add(new List<int>(current));
            }



            for (int i = start; i < candidates.Length; i++)
            {

                int num = candidates[i];
                if (num > target)
                {
                    continue;
                }
                if (i > start && num == candidates[i - 1])
                    continue;



                current.Add(num);

                BackTracting(candidates, target - num, i+1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
