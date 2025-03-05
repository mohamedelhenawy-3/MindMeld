using System.Text;

namespace Convert_Between_int__string
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static string multi(string num1 ,string num2)
        {
            if (num1 == "0" || num2 == "0") return "0"; // Edge case

            int len1 = num1.Length, len2 = num2.Length;
            int[] result = new int[len1 + len2];


            for(int i = num1.Length - 1; i >= 0; i--)
            {
                for(int j=num2.Length - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int sum = mul + result[i + j + 1];
                    result[i + j + 1] = sum % 10;
                    result[i + j] = sum / 10;
                }
            }


            // convert array to string 
            StringBuilder sb = new StringBuilder();
            foreach(  int num in result)
            {
                sb.Append(num);
            }



            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}
