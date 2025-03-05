namespace Longest_Common_Prefix
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(v);
        }
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            return LCP(strs, 0, strs.Length - 1);
        }
        public string LCP(string[] strs,int left, int right)
        {
            if(left == right)
            {
                return strs[left];
            }
            int mid = (left + right) / 2;

            string LCPLeft = LCP(strs, left, mid);
            string LCPRight = LCP(strs, mid + 1, right);


            return Prefix(LCPLeft, LCPRight);
        }
        private string Prefix(string left ,string right)
        {
            int minlength = Math.Min(left.Length, right.Length);
            for (int i = 0; i < minlength; i++)
            {
                if (left[i] != right[i])
                {
                    return left.Substring(0, i);
                }
            }
            return left.Substring(0, minlength);
           
        }
    }
   
}
